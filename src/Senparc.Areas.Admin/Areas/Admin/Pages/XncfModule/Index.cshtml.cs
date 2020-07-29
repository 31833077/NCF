using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Senparc.CO2NET.Extensions;
using Senparc.Core.Models.DataBaseModel;
using Senparc.Ncf.Core.Enums;
using Senparc.Ncf.Core.Models;
using Senparc.Ncf.Core.Models.DataBaseModel;
using Senparc.Ncf.Service;
using Senparc.Ncf.XncfBase;
using Senparc.Service;
using Microsoft.Extensions.DependencyInjection;
using Senparc.CO2NET.Trace;

namespace Senparc.Areas.Admin.Areas.Admin.Pages
{
    public class XncfModuleIndexModel : BaseAdminPageModel
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly XncfModuleServiceExtension _xncfModuleService;
        private readonly SysMenuService _sysMenuService;
        private readonly Lazy<SystemConfigService> _systemConfigService;

        public XncfModuleIndexModel(IServiceProvider serviceProvider, XncfModuleServiceExtension xncfModuleService,
            SysMenuService sysMenuService, Lazy<SystemConfigService> systemConfigService)
        {
            CurrentMenu = "XncfModule";

            this._serviceProvider = serviceProvider;
            this._xncfModuleService = xncfModuleService;
            this._sysMenuService = sysMenuService;
            this._systemConfigService = systemConfigService;
        }

        [BindProperty(SupportsGet = true)]
        public int PageIndex { get; set; } = 1;

        /// <summary>
        /// ���ݿ��Ѵ��XncfModules
        /// </summary>
        public PagedList<XncfModule> XncfModules { get; set; }
        public List<IXncfRegister> NewXncfRegisters { get; set; }

        private void LoadNewXncfRegisters(PagedList<XncfModule> xncfModules)
        {
            NewXncfRegisters = Senparc.Ncf.XncfBase.Register.RegisterList.Where(z => !z.IgnoreInstall && !xncfModules.Exists(m => m.Uid == z.Uid && m.Version == z.Version)).ToList() ?? new List<IXncfRegister>();
        }

        public async Task OnGetAsync()
        {
            //���²˵�����
            await _sysMenuService.GetMenuDtoByCacheAsync(true).ConfigureAwait(false);
            XncfModules = await _xncfModuleService.GetObjectListAsync(PageIndex, 10, _ => true, _ => _.AddTime, Ncf.Core.Enums.OrderingType.Descending);
            LoadNewXncfRegisters(XncfModules);
        }

        /// <summary>
        /// ɨ����ģ��
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> OnGetScanAsync(string uid)
        {
            var result = await _xncfModuleService.InstallModuleAsync(uid);
            XncfModules = result.Item1;
            base.SetMessager(Ncf.Core.Enums.MessageType.info, result.Item2, true);

            //if (backpage=="Start")
            return RedirectToPage("Start", new { uid = uid });//ʼ�յ�����ҳ
            //return RedirectToPage("Index");
        }

        /// <summary>
        /// ���ء�ģ���������
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> OnPostHideManagerAsync()
        {
            //TODO:ʹ��DTO����
            var systemConfig = _systemConfigService.Value.GetObject(z => true);
            systemConfig.HideModuleManager = systemConfig.HideModuleManager.HasValue && systemConfig.HideModuleManager.Value == true ? false : true;
            await _systemConfigService.Value.SaveObjectAsync(systemConfig);
            if (systemConfig.HideModuleManager == true)
            {
                return RedirectToPage("../Index");
            }
            else
            {
                return RedirectToPage("./Index");
            }
        }

        /// <summary>
        /// ���ء�ģ��������� handler=HideManagerAjax
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> OnPostHideManagerAjaxAsync()
        {
            //TODO:ʹ��DTO����
            var systemConfig = _systemConfigService.Value.GetObject(z => true);
            systemConfig.HideModuleManager = systemConfig.HideModuleManager.HasValue && systemConfig.HideModuleManager.Value == true ? false : true;
            await _systemConfigService.Value.SaveObjectAsync(systemConfig);
            //if (systemConfig.HideModuleManager == true)
            //{
            //    return RedirectToPage("../Index");
            //}
            //else
            //{
            //    return RedirectToPage("./Index");
            //}
            return Ok(new { systemConfig.HideModuleManager });
        }

        /// <summary>
        /// ��ȡ�Ѱ�װģ��ģ�� handler=Mofules
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> OnGetMofulesAsync(int pageIndex = 0, int pageSize = 0)
        {
            //���²˵�����
            await _sysMenuService.GetMenuDtoByCacheAsync(true).ConfigureAwait(false);
            PagedList<XncfModule> xncfModules = await _xncfModuleService.GetObjectListAsync(pageIndex, pageSize, _ => true, _ => _.AddTime, Ncf.Core.Enums.OrderingType.Descending);
            //xncfModules.FirstOrDefault().
            var xncfRegisterList = XncfRegisterList.Select(_ => new { _.Uid, homeUrl = _.GetAreaHomeUrl(),_.Icon });
            var result = from xncfModule in xncfModules
                         join xncfRegister in xncfRegisterList on xncfModule.Uid equals xncfRegister.Uid
                         into xncfRegister_left
                         from xncfRegister in xncfRegister_left.DefaultIfEmpty()
                         select new
                         {
                             xncfModule,
                             xncfRegister
                         };
            return Ok(new { result, FullSystemConfig.HideModuleManager });
        }

        /// <summary>
        /// ��ȡδ��װģ��ģ�� handler=UnMofules
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> OnGetUnMofulesAsync()
        {
            var xncfModules = await _xncfModuleService.GetObjectListAsync(0, 0, _ => true, _ => _.AddTime, Ncf.Core.Enums.OrderingType.Descending);
            var newXncfRegisters = Senparc.Ncf.XncfBase.Register.RegisterList.Where(z => !z.IgnoreInstall && !xncfModules.Exists(m => m.Uid == z.Uid && m.Version == z.Version)).ToList() ?? new List<IXncfRegister>();
            return Ok(newXncfRegisters.Select(_ => new { _.MenuName, _.Name, _.Uid, _.Version,_.Icon })); ;
        }

        /// <summary>
        /// ɨ����ģ�� handler=ScanAjax
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> OnGetScanAjaxAsync(string uid)
        {
            var result = await _xncfModuleService.InstallModuleAsync(uid);
            //XncfModules = result.Item1;
            //base.SetMessager(Ncf.Core.Enums.MessageType.info, result.Item2, true);
            return Ok(result.Item1);
            //return RedirectToPage("Index");
        }
    }
}