local LuaLog, tablePrint_ptk = setLuaLog(1, "TestUI1")
local className = "TestUI1"
local TestUI1 = Declare(className, Class(className, GameBaseUI))

function TestUI1:ctor()
	LuaLog("ctor")
end

function TestUI1:dcor()
	LuaLog("dcor")
end

function TestUI1:Init( ... )
	-- local function OnAssetLoaded( obj )
	-- 	LuaLog(obj.name)
	-- 	local uiObj = self:AddCanvasWithInstantiate(obj)

	-- 	local slider = self:GetSliderControl(uiObj, "bg/Slider")
	-- 	slider.value = 1
	-- 	LuaLog(slider.value)

	-- 	local function OnAssetLoaded1( obj )
	-- 		local uiImg = self:AddChildWithInstantiate(obj, uiObj)
	-- 		local img = self:GetImageControl(uiImg)

	-- 		local function OnAssetLoaded2( obj )
	-- 			LuaLog(obj.name)
	-- 			img.sprite = self:GetSpriteRendererWithSprite(obj)
	-- 		end

	-- 		for i=1,10 do
	-- 			local iname = 100 + i
	-- 			self:AssetLoad(iname, OnAssetLoaded2)
	-- 		end
	-- 	end

	-- 	self:AssetLoad("test1", OnAssetLoaded1)
	-- 	self.asset:UnLoad()
	-- end

	-- -- local function OnProgress( o )
	-- -- 	LuaLog(o)
	-- -- end

	-- self.asset = self:AssetLoad("TestPanel", OnAssetLoaded)

	-- local function OnSpriteComplete( sprite )
	-- 	local img = self:GetImageControl(self.uiObj1)
	-- 	img.sprite = sprite
	-- end

	-- local function OnInstantiateComplete( uiObj )

	-- 	self:AssetLoadWithChildInstantiate("test1", uiObj, OnInstantiateComplete1)
	-- end

	local function OnInstantiateComplete1( uiObj1 )
		self.uiObj1 = uiObj1
		for i=1,10 do
			local iname = 100 + i
			self:AssetLoadWithSprite(iname, function(sprite) local img = self:GetImageControl(self.uiObj1) img.sprite = sprite end)
		end
	end
	self:AssetLoadWithCanvasInstantiate("TestPanel", function(uiObj) self:AssetLoadWithChildInstantiate("test1", uiObj, OnInstantiateComplete1) end)
end