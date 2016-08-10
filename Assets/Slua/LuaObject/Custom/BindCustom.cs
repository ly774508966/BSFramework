﻿using System;
using System.Collections.Generic;
namespace SLua {
	[LuaBinder(3)]
	public class BindCustom {
		public static Action<IntPtr>[] GetBindList() {
			Action<IntPtr>[] list= {
				Lua_BSFramework_Asset.reg,
				Lua_BSFramework_AssetMgr.reg,
				Lua_BSFramework_Bundle.reg,
				Lua_BSFramework_ResourceHelper.reg,
				Lua_LTDescrImpl.reg,
				Lua_LeanAudioStream.reg,
				Lua_TweenAction.reg,
				Lua_LeanTweenType.reg,
				Lua_LeanTween.reg,
				Lua_BSFramework_Tools_LuaHelper.reg,
				Lua_BSFramework_Tools_Utils.reg,
				Lua_Custom.reg,
				Lua_Deleg.reg,
				Lua_foostruct.reg,
				Lua_FloatEvent.reg,
				Lua_ListViewEvent.reg,
				Lua_SLuaTest.reg,
				Lua_System_Collections_Generic_List_1_int.reg,
				Lua_XXList.reg,
				Lua_AbsClass.reg,
				Lua_HelloWorld.reg,
				Lua_System_Collections_Generic_Dictionary_2_int_string.reg,
				Lua_System_String.reg,
			};
			return list;
		}
	}
}
