
EXTRA_DIST =  

# Warning: This is an automatically generated file, do not edit!

if ENABLE_DEBUG
ASSEMBLY_COMPILER_COMMAND = dmcs
ASSEMBLY_COMPILER_FLAGS =  -noconfig -codepage:utf8 -warn:4 -optimize- -debug "-define:DEBUG;TRACE"
ASSEMBLY = bin/Debug/CGurus.Weather.WundergroundAPI.dll
ASSEMBLY_MDB = $(ASSEMBLY).mdb
COMPILE_TARGET = library
PROJECT_REFERENCES =  \
	../External/Newtonsoft.Json/Src/Newtonsoft.Json/bin/Debug/Schumix/Newtonsoft.Json.dll
BUILD_DIR = bin/Debug

CGURUS_WEATHER_WUNDERGROUNDAPI_DLL_MDB_SOURCE=bin/Debug/CGurus.Weather.WundergroundAPI.dll.mdb
CGURUS_WEATHER_WUNDERGROUNDAPI_DLL_MDB=$(BUILD_DIR)/CGurus.Weather.WundergroundAPI.dll.mdb
NEWTONSOFT_JSON_DLL_SOURCE=../External/Newtonsoft.Json/Src/Newtonsoft.Json/bin/Debug/Schumix/Newtonsoft.Json.dll
NEWTONSOFT_JSON_DLL_MDB_SOURCE=../External/Newtonsoft.Json/Src/Newtonsoft.Json/bin/Debug/Schumix/Newtonsoft.Json.dll.mdb
NEWTONSOFT_JSON_DLL_MDB=$(BUILD_DIR)/Newtonsoft.Json.dll.mdb

endif

if ENABLE_RELEASE
ASSEMBLY_COMPILER_COMMAND = dmcs
ASSEMBLY_COMPILER_FLAGS =  -noconfig -codepage:utf8 -warn:4 -optimize+ "-define:TRACE"
ASSEMBLY = bin/Release/CGurus.Weather.WundergroundAPI.dll
ASSEMBLY_MDB = 
COMPILE_TARGET = library
PROJECT_REFERENCES =  \
	../External/Newtonsoft.Json/Src/Newtonsoft.Json/bin/Release/Schumix/Newtonsoft.Json.dll
BUILD_DIR = bin/Release

CGURUS_WEATHER_WUNDERGROUNDAPI_DLL_MDB=
NEWTONSOFT_JSON_DLL_SOURCE=../External/Newtonsoft.Json/Src/Newtonsoft.Json/bin/Release/Schumix/Newtonsoft.Json.dll
NEWTONSOFT_JSON_DLL_MDB=

endif

AL=al
SATELLITE_ASSEMBLY_NAME=$(notdir $(basename $(ASSEMBLY))).resources.dll

PROGRAMFILES = \
	$(CGURUS_WEATHER_WUNDERGROUNDAPI_DLL_MDB) \
	$(NEWTONSOFT_JSON_DLL) \
	$(NEWTONSOFT_JSON_DLL_MDB)  

LINUX_PKGCONFIG = \
	$(WUNDERGROUNDAPI_PC)  


RESGEN=resgen2
	
all: $(ASSEMBLY) $(PROGRAMFILES) $(LINUX_PKGCONFIG) 

FILES = \
	Models/Accumulation.cs \
	Models/Alert.cs \
	Models/AlertData.cs \
	Models/FctTime.cs \
	Models/Forecast.cs \
	Models/ForecastData.cs \
	Models/ForecastDay.cs \
	Models/ForecastHourly.cs \
	Models/ForecastHourlyData.cs \
	Models/Response.cs \
	Models/SimpleForecast.cs \
	Models/TemperatureCF.cs \
	Models/TemperatureEM.cs \
	Models/TxtForecast.cs \
	Models/Wind.cs \
	Models/Date.cs \
	Models/Enums.cs \
	Models/SimpleForecastDay.cs \
	Properties/AssemblyInfo.cs \
	Utilities/RestRequest.cs \
	Utilities/BoolConverter.cs \
	Utilities/DoubleConverter.cs \
	Utilities/EpochConverter.cs \
	WApi.cs 

DATA_FILES = 

RESOURCES = 

EXTRAS = \
	wundergroundapi.pc.in 

REFERENCES =  \
	System \
	System.Core

DLL_REFERENCES = 

CLEANFILES = $(PROGRAMFILES) $(LINUX_PKGCONFIG) 

include $(top_srcdir)/Makefile.include

NEWTONSOFT_JSON_DLL = $(BUILD_DIR)/Newtonsoft.Json.dll
WUNDERGROUNDAPI_PC = $(BUILD_DIR)/wundergroundapi.pc

$(eval $(call emit-deploy-target,NEWTONSOFT_JSON_DLL))
$(eval $(call emit-deploy-target,NEWTONSOFT_JSON_DLL_MDB))
$(eval $(call emit-deploy-wrapper,WUNDERGROUNDAPI_PC,wundergroundapi.pc))


$(eval $(call emit_resgen_targets))
$(build_xamlg_list): %.xaml.g.cs: %.xaml
	xamlg '$<'

$(ASSEMBLY_MDB): $(ASSEMBLY)

$(ASSEMBLY): $(build_sources) $(build_resources) $(build_datafiles) $(DLL_REFERENCES) $(PROJECT_REFERENCES) $(build_xamlg_list) $(build_satellite_assembly_list)
	mkdir -p $(shell dirname $(ASSEMBLY))
	$(ASSEMBLY_COMPILER_COMMAND) $(ASSEMBLY_COMPILER_FLAGS) -out:$(ASSEMBLY) -target:$(COMPILE_TARGET) $(build_sources_embed) $(build_resources_embed) $(build_references_ref)
