using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_GUILayoutOption : LuaObject {
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.GUILayoutOption");
		createTypeMetatable(l,null, typeof(UnityEngine.GUILayoutOption));
	}
}
