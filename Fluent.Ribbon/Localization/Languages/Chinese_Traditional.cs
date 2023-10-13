#pragma warning disable

namespace Fluent.Localization.Languages
{
    [RibbonLocalization("Chinese_Traditional", "zh-TW")]
    public class Chinese_Traditional : RibbonLocalizationBase
    {
        public override string Automatic { get; } = "自動";
        public override string BackstageBackButtonUid { get; } = FallbackLocalization.BackstageBackButtonUid /* Close Backstage */;
        public override string BackstageButtonKeyTip { get; } = FallbackLocalization.BackstageButtonKeyTip /* F */;
        public override string BackstageButtonText { get; } = "檔案";
        public override string CustomizeStatusBar { get; } = "自訂狀態欄";
        public override string DisplayOptionsButtonScreenTipText { get; } = "設定功能區顯示選項。";
        public override string DisplayOptionsButtonScreenTipTitle { get; } = "功能區顯示選項";
        public override string ExpandRibbon { get; } = "展開功能區";
        public override string MinimizeRibbon { get; } = "最小化功能區";
        public override string MoreColors { get; } = "更多的顏色...";
        public override string NoColor { get; } = "沒有顏色";
        public override string QuickAccessToolBarDropDownButtonTooltip { get; } = "自訂快速存取工具列";
        public override string QuickAccessToolBarMenuHeader { get; } = "自訂快速存取工具列";
        public override string QuickAccessToolBarMenuShowAbove { get; } = "在功能區上方顯示";
        public override string QuickAccessToolBarMenuShowBelow { get; } = "在功能區下方顯示";
        public override string QuickAccessToolBarMoreControlsButtonTooltip { get; } = "其他命令";
        public override string RibbonContextMenuAddGallery { get; } = "在快速存取工具列中加入樣式";
        public override string RibbonContextMenuAddGroup { get; } = "在快速存取工具列中加入組";
        public override string RibbonContextMenuAddItem { get; } = "加入到快速存取工具列";
        public override string RibbonContextMenuAddMenu { get; } = "在快速存取工具列中加入功能表";
        public override string RibbonContextMenuCustomizeQuickAccessToolBar { get; } = "自訂快速存取工具列...";
        public override string RibbonContextMenuCustomizeRibbon { get; } = "自訂功能區...";
        public override string RibbonContextMenuMinimizeRibbon { get; } = "功能區最小化";
        public override string RibbonContextMenuRemoveItem { get; } = "在快速存取工具列中移除";
        public override string RibbonContextMenuShowAbove { get; } = "在功能區上方顯示快速存取工具列";
        public override string RibbonContextMenuShowBelow { get; } = "在功能區下方顯示快速存取工具列";
        public override string RibbonLayout { get; } = "布局功能區";
        public override string ScreenTipDisableReasonHeader { get; } = "此命令當前已被禁用。";
        public override string ScreenTipF1LabelHeader { get; } = "說明(F1)";
        public override string ShowRibbon { get; } = "顯示功能區";
        public override string UseClassicRibbon { get; } = "使用標準功能區(_U)";
        public override string UseSimplifiedRibbon { get; } = "使用精簡功能區(_U)";
    }
}