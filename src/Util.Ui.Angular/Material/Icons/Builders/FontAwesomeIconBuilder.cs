﻿using Util.Ui.Builders;
using Util.Ui.Configs;
using Util.Ui.Enums;

namespace Util.Ui.Material.Icons.Builders {
    /// <summary>
    /// FontAwesome图标生成器
    /// </summary>
    public class FontAwesomeIconBuilder : TagBuilder {
        /// <summary>
        /// 初始化FontAwesome图标生成器
        /// </summary>
        public FontAwesomeIconBuilder() : base( "i" ) {
        }

        /// <summary>
        /// 设置图标
        /// </summary>
        /// <param name="config">配置</param>
        /// <param name="key">键</param>
        public void SetIcon( IConfig config, string key = UiConst.FontAwesomeIcon ) {
            Class( config.GetValue<FontAwesomeIcon?>( key ).GetIcon() );
        }

        /// <summary>
        /// 配置图标大小
        /// </summary>
        /// <param name="config">配置</param>
        public void SetSize( IConfig config ) {
            if( config.Contains( UiConst.Size ) )
                Class( config.GetValue<IconSize>( UiConst.Size ).Description() );
        }
    }
}
