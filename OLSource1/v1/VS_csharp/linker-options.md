---
title: "Linker Options"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "link"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "linker [C++]"
  - "linker [C++], options listed"
  - "libraries [C++], linking to COFF"
  - "LINK tool [C++], linker options"
ms.assetid: c1d51b8a-bd23-416d-81e4-900e02b2c129
caps.latest.revision: 41
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Linker Options
LINK.exe links Common Object File Format (COFF) object files and libraries to create an executable (.exe) file or a dynamic-link library (DLL).  
  
 The following table lists options for LINK.exe. For more information about LINK, see:  
  
-   [Compiler-Controlled LINK Options](../VS_csharp/compiler-controlled-link-options.md)  
  
-   [LINK Input Files](../VS_csharp/link-input-files.md)  
  
-   [LINK Output](../VS_csharp/link-output.md)  
  
-   [Reserved Words](../VS_csharp/reserved-words.md)  
  
 On the command line, linker options are not case-sensitive—for example, /base and /BASE mean the same thing. For details on how to specify each option on the command line or in Visual Studio, see the documentation for that option.  
  
 You can use the [comment](../VS_csharp/comment--c-c---.md) pragma to specify some linker options.  
  
|Option|Purpose|  
|------------|-------------|  
|[@](../VS_csharp/@--specify-a-linker-response-file-.md)|Specifies a response file.|  
|[/ALIGN](../VS_csharp/-align--section-alignment-.md)|Specifies the alignment of each section.|  
|[/ALLOWBIND](../VS_csharp/-allowbind--prevent-dll-binding-.md)|Specifies that a DLL cannot be bound.|  
|[/ALLOWISOLATION](../VS_csharp/-allowisolation--manifest-lookup-.md)|Specifies behavior for manifest lookup.|  
|[/APPCONTAINER](../VS_csharp/-appcontainer--windows-store-app-.md)|Specifies whether the app must run within an appcontainer process environment.|  
|[/ASSEMBLYDEBUG](../VS_csharp/-assemblydebug--add-debuggableattribute-.md)|Adds the <xref:System.Diagnostics.DebuggableAttribute*> to a managed image.|  
|[/ASSEMBLYLINKRESOURCE](../VS_csharp/-assemblylinkresource--link-to-.net-framework-resource-.md)|Creates a link to a managed resource.|  
|[/ASSEMBLYMODULE](../VS_csharp/-assemblymodule--add-a-msil-module-to-the-assembly-.md)|Specifies that a Microsoft intermediate language (MSIL) module should be imported into the assembly.|  
|[/ASSEMBLYRESOURCE](../VS_csharp/-assemblyresource--embed-a-managed-resource-.md)|Embeds a managed resource file in an assembly.|  
|[/BASE](../VS_csharp/-base--base-address-.md)|Sets a base address for the program.|  
|[/CGTHREADS](../VS_csharp/-cgthreads--compiler-threads-.md)|Sets number of cl.exe threads to use for optimization and code generation when link-time code generation is specified.|  
|[/CLRIMAGETYPE](../VS_csharp/-clrimagetype--specify-type-of-clr-image-.md)|Sets the type (IJW, pure, or safe) of a CLR image.|  
|[/CLRSUPPORTLASTERROR](../VS_csharp/-clrsupportlasterror--preserve-last-error-code-for-pinvoke-calls-.md)|Preserves the last error code of functions that are called through the P/Invoke mechanism.|  
|[/CLRTHREADATTRIBUTE](../VS_csharp/-clrthreadattribute--set-clr-thread-attribute-.md)|Specifies the threading attribute to apply to the entry point of your CLR program.|  
|[/CLRUNMANAGEDCODECHECK](../VS_csharp/-clrunmanagedcodecheck--add-supressunmanagedcodesecurityattribute-.md)|Specifies whether the linker will apply the SuppressUnmanagedCodeSecurity attribute to linker-generated PInvoke stubs that call from managed code into native DLLs.|  
|[/DEBUG](../VS_csharp/-debug--generate-debug-info-.md)|Creates debugging information.|  
|[/DEBUGTYPE](../VS_csharp/-debugtype--debug-info-options-.md)|Specifies which data to include in debugging information.|  
|[/DEF](../VS_csharp/-def--specify-module-definition-file-.md)|Passes a module-definition (.def) file to the linker.|  
|[/DEFAULTLIB](../VS_csharp/-defaultlib--specify-default-library-.md)|Searches the specified library when external references are resolved.|  
|[/DELAY](../VS_csharp/-delay--delay-load-import-settings-.md)|Controls the delayed loading of DLLs.|  
|[/DELAYLOAD](../VS_csharp/-delayload--delay-load-import-.md)|Causes the delayed loading of the specified DLL.|  
|[/DELAYSIGN](../VS_csharp/-delaysign--partially-sign-an-assembly-.md)|Partially signs an assembly.|  
|[/DLL](../VS_csharp/-dll--build-a-dll-.md)|Builds a DLL.|  
|[/DRIVER](../VS_csharp/-driver--windows-nt-kernel-mode-driver-.md)|Creates a kernel mode driver.|  
|[/DYNAMICBASE](../VS_csharp/-dynamicbase--use-address-space-layout-randomization-.md)|Specifies whether to generate an executable image that can be randomly rebased at load time by using the address space layout randomization (ASLR) feature.|  
|[/ENTRY](../VS_csharp/-entry--entry-point-symbol-.md)|Sets the starting address.|  
|[/errorReport](../VS_csharp/-errorreport--report-internal-linker-errors-.md)|Reports internal linker errors to Microsoft.|  
|[/EXPORT](../VS_csharp/-export--exports-a-function-.md)|Exports a function.|  
|[/FIXED](../VS_csharp/-fixed--fixed-base-address-.md)|Creates a program that can be loaded only at its preferred base address.|  
|[/FORCE](../VS_csharp/-force--force-file-output-.md)|Forces a link to complete even with unresolved symbols or symbols defined more than once.|  
|[/FUNCTIONPADMIN](../VS_csharp/-functionpadmin--create-hotpatchable-image-.md)|Creates an image that can be hot patched.|  
|[/GENPROFILE, /FASTGENPROFILE](../VS_csharp/-genprofile---fastgenprofile--generate-profiling-instrumented-build-.md)|Both of these options specify generation of a .pgd file by the linker to support profile-guided optimization (PGO). /GENPROFILE and /FASTGENPROFILE use different default parameters.|  
|[/GUARD](../VS_csharp/-guard--enable-guard-checks-.md)|Enables Control Flow Guard protection.|  
|[/HEAP](../VS_csharp/-heap--set-heap-size-.md)|Sets the size of the heap, in bytes.|  
|[/HIGHENTROPYVA](../VS_csharp/-highentropyva--support-64-bit-aslr-.md)|Specifies support for high-entropy 64-bit address space layout randomization (ASLR).|  
|[/IDLOUT](../VS_csharp/-idlout--name-midl-output-files-.md)|Specifies the name of the .idl file and other MIDL output files.|  
|[/IGNORE](../VS_csharp/-ignore--ignore-specific-warnings-.md)|Suppresses output of specified linker warnings.|  
|[/IGNOREIDL](../VS_csharp/-ignoreidl--don-t-process-attributes-into-midl-.md)|Prevents the processing of attribute information into an .idl file.|  
|[/IMPLIB](../VS_csharp/-implib--name-import-library-.md)|Overrides the default import library name.|  
|[/INCLUDE](../VS_csharp/-include--force-symbol-references-.md)|Forces symbol references.|  
|[/INCREMENTAL](../VS_csharp/-incremental--link-incrementally-.md)|Controls incremental linking.|  
|[/INTEGRITYCHECK](../VS_csharp/-integritycheck--require-signature-check-.md)|Specifies that the module requires a signature check at load time.|  
|[/KEYCONTAINER](../VS_csharp/-keycontainer--specify-a-key-container-to-sign-an-assembly-.md)|Specifies a key container to sign an assembly.|  
|[/KEYFILE](../VS_csharp/-keyfile--specify-key-or-key-pair-to-sign-an-assembly-.md)|Specifies a key or key pair to sign an assembly.|  
|[/LARGEADDRESSAWARE](../VS_csharp/-largeaddressaware--handle-large-addresses-.md)|Tells the compiler that the application supports addresses larger than two gigabytes|  
|[/LIBPATH](../VS_csharp/-libpath--additional-libpath-.md)|Specifies a path to search before the environmental library path.|  
|[/LTCG](../VS_csharp/-ltcg--link-time-code-generation-.md)|Specifies link-time code generation.|  
|[/MACHINE](../VS_csharp/-machine--specify-target-platform-.md)|Specifies the target platform.|  
|[/MANIFEST](../VS_csharp/-manifest--create-side-by-side-assembly-manifest-.md)|Creates a side-by-side manifest file and optionally embeds it in the binary.|  
|[/MANIFESTDEPENDENCY](../VS_csharp/-manifestdependency--specify-manifest-dependencies-.md)|Specifies a <dependentAssembly\> section in the manifest file.|  
|[/MANIFESTFILE](../VS_csharp/-manifestfile--name-manifest-file-.md)|Changes the default name of the manifest file.|  
|[/MANIFESTINPUT](../VS_csharp/-manifestinput--specify-manifest-input-.md)|Specifies a manifest input file for the linker to process and embed in the binary. You can use this option multiple times to specify more than one manifest input file.|  
|[/MANIFESTUAC](../VS_csharp/-manifestuac--embeds-uac-information-in-manifest-.md)|Specifies whether User Account Control (UAC) information is embedded in the program manifest.|  
|[/MAP](../VS_csharp/-map--generate-mapfile-.md)|Creates a mapfile.|  
|[/MAPINFO](../VS_csharp/-mapinfo--include-information-in-mapfile-.md)|Includes the specified information in the mapfile.|  
|[/MERGE](../VS_csharp/-merge--combine-sections-.md)|Combines sections.|  
|[/MIDL](../VS_csharp/-midl--specify-midl-command-line-options-.md)|Specifies MIDL command-line options.|  
|[/NOASSEMBLY](../VS_csharp/-noassembly--create-a-msil-module-.md)|Suppresses the creation of a .NET Framework assembly.|  
|[/NODEFAULTLIB](../VS_csharp/-nodefaultlib--ignore-libraries-.md)|Ignores all (or the specified) default libraries when external references are resolved.|  
|[/NOENTRY](../VS_csharp/-noentry--no-entry-point-.md)|Creates a resource-only DLL.|  
|[/NOLOGO](../VS_csharp/-nologo--suppress-startup-banner---linker-.md)|Suppresses the startup banner.|  
|[/NXCOMPAT](../VS_csharp/-nxcompat--compatible-with-data-execution-prevention-.md)|Marks an executable as verified to be compatible with the Windows Data Execution Prevention feature.|  
|[/OPT](../VS_csharp/-opt--optimizations-.md)|Controls LINK optimizations.|  
|[/ORDER](../VS_csharp/-order--put-functions-in-order-.md)|Places COMDATs into the image in a predetermined order.|  
|[/OUT](../VS_csharp/-out--output-file-name-.md)|Specifies the output file name.|  
|[/PDB](../VS_csharp/-pdb--use-program-database-.md)|Creates a program database (PDB) file.|  
|[/PDBALTPATH](../VS_csharp/-pdbaltpath--use-alternate-pdb-path-.md)|Uses an alternate location to save a PDB file.|  
|[/PDBSTRIPPED](../VS_csharp/-pdbstripped--strip-private-symbols-.md)|Creates a program database (PDB) file that has no private symbols.|  
|[/PGD](../VS_csharp/-pgd--specify-database-for-profile-guided-optimizations-.md)|Specifies a .pgd file for profile-guided optimizations.|  
|[/PROFILE](../VS_csharp/-profile--performance-tools-profiler-.md)|Produces an output file that can be used with the Performance Tools profiler.|  
|[/RELEASE](../VS_csharp/-release--set-the-checksum-.md)|Sets the Checksum in the .exe header.|  
|[/SAFESEH](../VS_csharp/-safeseh--image-has-safe-exception-handlers-.md)|Specifies that the image will contain a table of safe exception handlers.|  
|[/SECTION](../VS_csharp/-section--specify-section-attributes-.md)|Overrides the attributes of a section.|  
|[/STACK](../VS_csharp/-stack--stack-allocations-.md)|Sets the size of the stack in bytes.|  
|[/STUB](../VS_csharp/-stub--ms-dos-stub-file-name-.md)|Attaches an MS-DOS stub program to a Win32 program.|  
|[/SUBSYSTEM](../VS_csharp/-subsystem--specify-subsystem-.md)|Tells the operating system how to run the .exe file.|  
|[/SWAPRUN](../VS_csharp/-swaprun--load-linker-output-to-swap-file-.md)|Tells the operating system to copy the linker output to a swap file before it is run.|  
|[/TLBID](../VS_csharp/-tlbid--specify-resource-id-for-typelib-.md)|Specifies the resource ID of the linker-generated type library.|  
|[/TLBOUT](../VS_csharp/-tlbout--name-.tlb-file-.md)|Specifies the name of the .tlb file and other MIDL output files.|  
|[/TSAWARE](../VS_csharp/-tsaware--create-terminal-server-aware-application-.md)|Creates an application that is designed specifically to run under Terminal Server.|  
|[/VERBOSE](../VS_csharp/-verbose--print-progress-messages-.md)|Prints linker progress messages.|  
|[/VERSION](../VS_csharp/-version--version-information-.md)|Assigns a version number.|  
|[/WHOLEARCHIVE](../VS_csharp/-wholearchive--include-all-library-object-files-.md)|Includes every object file from specified static libraries.|  
|[/WINMD](../VS_csharp/-winmd--generate-windows-metadata-.md)|Enables generation of a Windows Runtime Metadata file.|  
|[/WINMDFILE](../VS_csharp/-winmdfile--specify-winmd-file-.md)|Specifies the file name for the Windows Runtime Metadata (winmd) output file that's generated by the [/WINMD](../VS_csharp/-winmd--generate-windows-metadata-.md) linker option.|  
|[/WINMDKEYFILE](../VS_csharp/-winmdkeyfile--specify-winmd-key-file-.md)|Specifies a key or key pair to sign a Windows Runtime Metadata file.|  
|[/WINMDKEYCONTAINER](../VS_csharp/-winmdkeycontainer--specify-key-container-.md)|Specifies a key container to sign a Windows Metadata file.|  
|[/WINMDDELAYSIGN](../VS_csharp/-winmddelaysign--partially-sign-a-winmd-.md)|Partially signs a Windows Runtime Metadata (.winmd) file by placing the public key in the winmd file.|  
|[/WX](../VS_csharp/-wx--treat-linker-warnings-as-errors-.md)|Treats linker warnings as errors.|  
  
 For more information, see [Compiler-Controlled LINK Options](../VS_csharp/compiler-controlled-link-options.md).  
  
## See Also  
 [C/C++ Building Reference](../VS_csharp/c-c---building-reference.md)   
 [Setting Linker Options](../VS_csharp/setting-linker-options.md)   
 [Frequently Asked Questions on Building](assetId:///56a3bb8f-0181-4989-bab4-a07ba950ab08)