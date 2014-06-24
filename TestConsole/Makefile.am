
EXTRA_DIST =  

# Warning: This is an automatically generated file, do not edit!

if ENABLE_DEBUG
ASSEMBLY_COMPILER_COMMAND = dmcs
ASSEMBLY_COMPILER_FLAGS =  -noconfig -codepage:utf8 -warn:4 -optimize- -debug "-define:DEBUG;TRACE"
ASSEMBLY = bin/Debug/TestConsole.exe
ASSEMBLY_MDB = $(ASSEMBLY).mdb
COMPILE_TARGET = exe
PROJECT_REFERENCES =  \
	../WundergroundAPI/bin/Debug/CGurus.Weather.WundergroundAPI.dll
BUILD_DIR = bin/Debug/

TESTCONSOLE_EXE_MDB_SOURCE=bin/Debug/TestConsole.exe.mdb
TESTCONSOLE_EXE_MDB=$(BUILD_DIR)/TestConsole.exe.mdb
CGURUS_WEATHER_WUNDERGROUNDAPI_DLL_SOURCE=../WundergroundAPI/bin/Debug/CGurus.Weather.WundergroundAPI.dll
CGURUS_WEATHER_WUNDERGROUNDAPI_DLL_MDB_SOURCE=../WundergroundAPI/bin/Debug/CGurus.Weather.WundergroundAPI.dll.mdb
CGURUS_WEATHER_WUNDERGROUNDAPI_DLL_MDB=$(BUILD_DIR)/CGurus.Weather.WundergroundAPI.dll.mdb
NEWTONSOFT_JSON_DLL_SOURCE=../External/Newtonsoft.Json/Src/Newtonsoft.Json/bin/Debug/Schumix/Newtonsoft.Json.dll
NEWTONSOFT_JSON_DLL_MDB_SOURCE=../External/Newtonsoft.Json/Src/Newtonsoft.Json/bin/Debug/Schumix/Newtonsoft.Json.dll.mdb
NEWTONSOFT_JSON_DLL_MDB=$(BUILD_DIR)/Newtonsoft.Json.dll.mdb

endif

if ENABLE_RELEASE
ASSEMBLY_COMPILER_COMMAND = dmcs
ASSEMBLY_COMPILER_FLAGS =  -noconfig -codepage:utf8 -warn:4 -optimize+ "-define:TRACE"
ASSEMBLY = bin/Release/TestConsole.exe
ASSEMBLY_MDB = 
COMPILE_TARGET = exe
PROJECT_REFERENCES =  \
	../WundergroundAPI/bin/Release/CGurus.Weather.WundergroundAPI.dll
BUILD_DIR = bin/Release/

TESTCONSOLE_EXE_MDB=
CGURUS_WEATHER_WUNDERGROUNDAPI_DLL_SOURCE=../WundergroundAPI/bin/Release/CGurus.Weather.WundergroundAPI.dll
CGURUS_WEATHER_WUNDERGROUNDAPI_DLL_MDB=
NEWTONSOFT_JSON_DLL_SOURCE=../External/Newtonsoft.Json/Src/Newtonsoft.Json/bin/Release/Schumix/Newtonsoft.Json.dll
NEWTONSOFT_JSON_DLL_MDB=

endif

AL=al
SATELLITE_ASSEMBLY_NAME=$(notdir $(basename $(ASSEMBLY))).resources.dll

PROGRAMFILES = \
	$(TESTCONSOLE_EXE_MDB) \
	$(CGURUS_WEATHER_WUNDERGROUNDAPI_DLL) \
	$(CGURUS_WEATHER_WUNDERGROUNDAPI_DLL_MDB) \
	$(NEWTONSOFT_JSON_DLL) \
	$(NEWTONSOFT_JSON_DLL_MDB)  

BINARIES = \
	$(TESTCONSOLE)  


RESGEN=resgen2
	
all: $(ASSEMBLY) $(PROGRAMFILES) $(BINARIES) 

FILES = \
	Program.cs \
	Properties/AssemblyInfo.cs 

DATA_FILES = 

RESOURCES = 

EXTRAS = \
	testconsole.in 

REFERENCES =  \
	System

DLL_REFERENCES = 

CLEANFILES = $(PROGRAMFILES) $(BINARIES) 

include $(top_srcdir)/Makefile.include

CGURUS_WEATHER_WUNDERGROUNDAPI_DLL = $(BUILD_DIR)/CGurus.Weather.WundergroundAPI.dll
NEWTONSOFT_JSON_DLL = $(BUILD_DIR)/Newtonsoft.Json.dll
TESTCONSOLE = $(BUILD_DIR)/testconsole

$(eval $(call emit-deploy-target,CGURUS_WEATHER_WUNDERGROUNDAPI_DLL))
$(eval $(call emit-deploy-target,CGURUS_WEATHER_WUNDERGROUNDAPI_DLL_MDB))
$(eval $(call emit-deploy-target,NEWTONSOFT_JSON_DLL))
$(eval $(call emit-deploy-target,NEWTONSOFT_JSON_DLL_MDB))
$(eval $(call emit-deploy-wrapper,TESTCONSOLE,testconsole,x))


$(eval $(call emit_resgen_targets))
$(build_xamlg_list): %.xaml.g.cs: %.xaml
	xamlg '$<'

$(ASSEMBLY_MDB): $(ASSEMBLY)

$(ASSEMBLY): $(build_sources) $(build_resources) $(build_datafiles) $(DLL_REFERENCES) $(PROJECT_REFERENCES) $(build_xamlg_list) $(build_satellite_assembly_list)
	mkdir -p $(shell dirname $(ASSEMBLY))
	$(ASSEMBLY_COMPILER_COMMAND) $(ASSEMBLY_COMPILER_FLAGS) -out:$(ASSEMBLY) -target:$(COMPILE_TARGET) $(build_sources_embed) $(build_resources_embed) $(build_references_ref)
