---
title: "Structures and Unions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "structures [Visual Studio SDK]"
ms.assetid: 9ff0a8f8-1ee6-4fdd-8b80-206436ff589b
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Structures and Unions
The following are structures and unions in the Visual Studio Debugging SDK.  
  
 [AD_PROCESS_ID](../VS_csharp/ad_process_id.md)  
 Specifies the process ID, which may be either a system ID or a GUID.  
  
 [BP_CONDITION](../VS_csharp/bp_condition.md)  
 Describes the conditions under which a breakpoint will fire.  
  
 [BP_ERROR_RESOLUTION_INFO](../VS_csharp/bp_error_resolution_info.md)  
 Describes the resolution of an error breakpoint, including location, program, and thread.  
  
 [BP_LOCATION](../VS_csharp/bp_location.md)  
 Specifies the type of structure used to describe the location of the breakpoint.  
  
 [BP_LOCATION_CODE_ADDRESS](../VS_csharp/bp_location_code_address.md)  
 Defines the components that describe the location of a breakpoint at an address in code.  
  
 [BP_LOCATION_CODE_CONTEXT](../VS_csharp/bp_location_code_context.md)  
 Describes the location of a breakpoint that is bound directly to an address in the program being debugged.  
  
 [BP_LOCATION_CODE_FILE_LINE](../VS_csharp/bp_location_code_file_line.md)  
 Describes the location of a breakpoint at line in a code source file.  
  
 [BP_LOCATION_CODE_FUNC_OFFSET](../VS_csharp/bp_location_code_func_offset.md)  
 Describes the offset location of a breakpoint at a function in code.  
  
 [BP_LOCATION_CODE_STRING](../VS_csharp/bp_location_code_string.md)  
 Used for setting code breakpoints based on a string that the user can enter from the IDE.  
  
 [BP_LOCATION_DATA_STRING](../VS_csharp/bp_location_data_string.md)  
 Used for setting data breakpoints that are based on a string that the user can enter from the IDE.  
  
 [BP_LOCATION_RESOLUTION](../VS_csharp/bp_location_resolution.md)  
 Describes the resolution of a breakpoint at a specific location.  
  
 [BP_PASSCOUNT](../VS_csharp/bp_passcount.md)  
 Describes the count and conditions upon which a breakpoint will be fired after having been previously passed.  
  
 [BP_REQUEST_INFO](../VS_csharp/bp_request_info.md)  
 Contains the information required to implement a breakpoint.  
  
 [BP_REQUEST_INFO2](../VS_csharp/bp_request_info2.md)  
 Contains the information required to implement a breakpoint (same as the [BP_REQUEST_INFO](../VS_csharp/bp_request_info.md) structure but includes vendor GUID, constraint and tracepoint information).  
  
 [BP_RESOLUTION_CODE](../VS_csharp/bp_resolution_code.md)  
 Describes the location of a code breakpoint.  
  
 [BP_RESOLUTION_DATA](../VS_csharp/bp_resolution_data.md)  
 Describes the result of binding a data breakpoint.  
  
 [BP_RESOLUTION_INFO](../VS_csharp/bp_resolution_info.md)  
 Describes the bound breakpoint information for either a code breakpoint or a data breakpoint.  
  
 [BP_RESOLUTION_LOCATION](../VS_csharp/bp_resolution_location.md)  
 Specifies the structure of the breakpoint resolution location.  
  
 [BSTR_ARRAY](../VS_csharp/bstr_array.md)  
 Describes an array of strings.  
  
 [BUILT_TYPE](../VS_csharp/built_type.md)  
 Specifies information about a field type taken from metadata.  
  
 [CODE_PATH](../VS_csharp/code_path.md)  
 Describes a call to a function or method.  
  
 [COMPUTER_INFO](../VS_csharp/computer_info.md)  
 Describes the computer on which the debugger is running.  
  
 [CONST_GUID_ARRAY](../VS_csharp/const_guid_array.md)  
 Describes a list of GUIDs.  
  
 [CONTEXT_INFO](../VS_csharp/context_info.md)  
 Describes a memory context or code context.  
  
 [DEBUG_ADDRESS](../VS_csharp/debug_address.md)  
 Describes an address in a program being debugged.  
  
 [DEBUG_ADDRESS_UNION](../VS_csharp/debug_address_union.md)  
 Represents one of a number of different kinds of addresses.  
  
 [DEBUG_CUSTOM_VIEWER](../VS_csharp/debug_custom_viewer.md)  
 Identifies a custom viewer or type visualizer.  
  
 [DEBUG_PROPERTY_INFO](../VS_csharp/debug_property_info.md)  
 Describes a debug property that in turn describes an object of a hierarchical nature that has name, type, and value.  
  
 [DEBUG_REFERENCE_INFO](../VS_csharp/debug_reference_info.md)  
 Describes a reference.  
  
 [DisassemblyData](../VS_csharp/disassemblydata.md)  
 Describes disassembly to the IDE for display.  
  
 [EXCEPTION_INFO](../VS_csharp/exception_info.md)  
 Describes an exception or run-time error thrown by the program being debugged.  
  
 [FIELD_INFO](../VS_csharp/field_info.md)  
 Describes a local variable, parameter, or other field.  
  
 [FRAMEINFO](../VS_csharp/frameinfo.md)  
 Describes a stack frame.  
  
 [GUID_ARRAY](../VS_csharp/guid_array.md)  
 Describes an array of unique identifiers for available debug engines.  
  
 [JMC_CODE_SPEC](../VS_csharp/jmc_code_spec.md)  
 Used to set the JustMyCode information for a module.  
  
 [MACHINE_INFO](../VS_csharp/machine_info.md)  
 Describes a particular machine.  
  
 [METADATA_ADDRESS_ARRAYELEM](../VS_csharp/metadata_address_arrayelem.md)  
 Describes an array element within an array.  
  
 [METADATA_ADDRESS_FIELD](../VS_csharp/metadata_address_field.md)  
 Describes the address of a field of a class or structure.  
  
 [METADATA_ADDRESS_LOCAL](../VS_csharp/metadata_address_local.md)  
 Describes the address of a local variable within a scope (usually a function or method).  
  
 [METADATA_ADDRESS_METHOD](../VS_csharp/metadata_address_method.md)  
 Describes the address of a method of a class.  
  
 [METADATA_ADDRESS_PARAM](../VS_csharp/metadata_address_param.md)  
 Describes a parameter of a method or function.  
  
 [METADATA_ADDRESS_RETVAL](../VS_csharp/metadata_address_retval.md)  
 Describes a return value from a method or function.  
  
 [METADATA_TYPE](../VS_csharp/metadata_type.md)  
 Describes a field type taken from metadata.  
  
 [MODULE_INFO](../VS_csharp/module_info.md)  
 Describes a particular module (DLL, EXE, or assembly).  
  
 [MODULE_SYMBOL_SEARCH_INFO](../VS_csharp/module_symbol_search_info.md)  
 Describes status information about symbol search paths that have been searched.  
  
 [NATIVE_ADDRESS](../VS_csharp/native_address.md)  
 Describes a native address.  
  
 [PDB_TYPE](../VS_csharp/pdb_type.md)  
 Describes a field type taken from a PDB symbol.  
  
 [PENDING_BP_STATE_INFO](../VS_csharp/pending_bp_state_info.md)  
 Describes the state of a breakpoint that is ready to bind to a code location.  
  
 [PROCESS_INFO](../VS_csharp/process_info.md)  
 Describes a process.  
  
 [PROGRAM_NODE_ARRAY](../VS_csharp/program_node_array.md)  
 Describes a list of [IDebugProgramNode2](../VS_csharp/idebugprogramnode2.md) objects that represent program nodes.  
  
 [PROVIDER_PROCESS_DATA](../VS_csharp/provider_process_data.md)  
 Describes processes running on a machine.  
  
 [TEXT_POSITION](../VS_csharp/text_position.md)  
 Describes the line and column location in the given text.  
  
 [THREADPROPERTIES](../VS_csharp/threadproperties.md)  
 Describes the properties of a thread.  
  
 [TYPE_INFO](../VS_csharp/type_info.md)  
 Describes a field's type.  
  
 [UNMANAGED_ADDRESS_PHYSICAL](../VS_csharp/unmanaged_address_physical.md)  
 Describes a physical address.  
  
 [UNMANAGED_ADDRESS_THIS_RELATIVE](../VS_csharp/unmanaged_address_this_relative.md)  
 Describes an address that is relative to a `this` pointer (`Me` in Visual Basic).  
  
## Requirements  
 Header: msdbg.h, sh.h, or ee.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [API Reference](../VS_csharp/api-reference--visual-studio-debugging-.md)