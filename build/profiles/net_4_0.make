# -*- makefile -*-

VBNC = MONO_PATH="$(topdir)/class/lib/$(PROFILE):$$MONO_PATH" $(RUNTIME) $(RUNTIME_FLAGS) --debug $(topdir)/class/lib/vbnc/vbnc.exe
BOOTSTRAP_VBNC = MONO_PATH="$(topdir)/class/lib/bootstrap$(PLATFORM_PATH_SEPARATOR)$$MONO_PATH" $(RUNTIME) $(RUNTIME_FLAGS) --debug  $(topdir)/class/lib/bootstrap/vbnc.exe

# nuttzing!

profile-check:
	@:

PROFILE_VBNC_FLAGS = 
FRAMEWORK_VERSION = 4.0
