using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_GUI_ClipScope : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.GUI.ClipScope o;
			UnityEngine.Rect a1;
			checkValueType(l,2,out a1);
			o=new UnityEngine.GUI.ClipScope(a1);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.GUI.ClipScope");
		createTypeMetatable(l,constructor, typeof(UnityEngine.GUI.ClipScope),typeof(UnityEngine.GUI.Scope));
	}
}
