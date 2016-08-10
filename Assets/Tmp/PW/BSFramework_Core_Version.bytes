-- Get current version number.
local _, _, majorv, minorv, rev = string.find(_VERSION, "(%d).(%d)[.]?([%d]?)")
local VersionNumber = tonumber(majorv) * 100 + tonumber(minorv) * 10 + (((string.len(rev) == 0) and 0) or tonumber(rev))

-- Declare current version number.
Declare("VERSION", VersionNumber)

-- Declare lua history version number.
Declare("VERSION_510", 510)
Declare("VERSION_520", 520)
Declare("VERSION_530", 530)

return VERSION
