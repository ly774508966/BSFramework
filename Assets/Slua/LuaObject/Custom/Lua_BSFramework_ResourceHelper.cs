using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_BSFramework_ResourceHelper : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LoadAssetInfo(IntPtr l) {
		try {
			BSFramework.ResourceHelper self=(BSFramework.ResourceHelper)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.LoadAssetInfo(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int getInstance_s(IntPtr l) {
		try {
			var ret=BSFramework.ResourceHelper.getInstance();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onFinish(IntPtr l) {
		try {
			BSFramework.ResourceHelper self=(BSFramework.ResourceHelper)checkSelf(l);
			System.Action v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onFinish=v;
			else if(op==1) self.onFinish+=v;
			else if(op==2) self.onFinish-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"BSFramework.ResourceHelper");
		addMember(l,LoadAssetInfo);
		addMember(l,getInstance_s);
		addMember(l,"onFinish",null,set_onFinish,true);
		createTypeMetatable(l,null, typeof(BSFramework.ResourceHelper),typeof(UnityEngine.MonoBehaviour));
	}
}
