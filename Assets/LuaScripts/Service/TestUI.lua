require "BSFramework.Base.GameBaseUI"

local LuaLog, tablePrint_ptk = setLuaLog(1, "TestUI")
local className = "TestUI"
local TestUI = Declare(className, Class(className, GameBaseUI))

function TestUI:ctor()
    LuaLog("TestUI:ctor=====================")
    local function function_name( obj )
    	LuaLog("================================")
    	local obj = GameObject.Instantiate(obj)
    	self:AddChildWithCanvas(obj)
    	self:SetPosition(obj, Vector3(1000,0,0))
    	-- LeanTween.moveX(obj.transform, 0, 0.1)
    	LeanTween.move(obj.transform, Vector3(0,0,0),1)

    	local txt = self:GetUIControl(obj, "bg/Button/Text", "UnityEngine.UI.Text")
    	LuaLog(txt.text)

    	local btn = self:GetButtonControl(obj, "bg/Button")
    	self:OnClick(btn, function() self:Click(1) end)

    	local slider = self:GetSliderControl(obj, "bg/Slider")
    	LuaLog(slider)
    	self:OnValueChanged(slider, function(args) self:Change(args) end)

    	local scrollbar = self:GetScrollbarControl(obj, "bg/Scrollbar")
    	LuaLog(scrollbar)
    	self:OnValueChanged(scrollbar, function(args) self:Change(args) end)

    	local dropdown = self:GetDropdownControl(obj, "bg/Dropdown")
    	LuaLog(dropdown)
    	self:OnValueChanged(dropdown, function(args) self:Change(args) end)

    	local srollRect = self:GetScrollRectControl(obj, "bg/Scroll View")
    	LuaLog(srollRect)
    	--self:OnValueChanged(srollRect, function(args) self:Change(args) end)

    	local InputField = self:GetInputFieldControl(obj, "bg/InputField")
    	LuaLog(InputField)
    	self:OnValueChanged(InputField, function(args) self:Change(args) end)
    	self:OnEndEdit(InputField, function(args) self:EndEdit(args, InputField) end)

    	local img = self:GetImageControl(obj, "bg/Image")
    	local function function_name1(args)
    		LuaLog(args)
    		LuaLog(self:GetSpriteRenderer(args))
    		img.sprite = self:GetSpriteRendererWithSprite(args)
    	end

    	self:CreateDynamicObject("101", GameObject, function_name1)

    	LuaLog(img)
    end
    self:CreateLayoutObject("TestPanel", GameObject, function_name)
end

function TestUI:Click(args)
	LuaLog(args)
end

function TestUI:Change(args)
	LuaLog(args)
end

function TestUI:EndEdit(args, obj)
	LuaLog(args)
	LuaLog(obj)
end

function TestUI:dtor()
    LuaLog("TestUI:dtor")
end