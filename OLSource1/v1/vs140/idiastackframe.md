---
title: "IDiaStackFrame"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaStackFrame interface"
ms.assetid: 486d25b8-a590-41c1-bdb5-faff3ae35632
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaStackFrame
Exposes the properties of a stack frame.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Methods in Vtable Order  
 The following are methods supported by this interface:  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaStackFrame::get_allocatesBasePointer](../vs140/idiastackframe--get_allocatesbasepointer.md)|Retrieves a flag indicating that the base pointer is allocated for code in this address range. This method is deprecated.|  
|[IDiaStackFrame::get_base](../vs140/idiastackframe--get_base.md)|Retrieves the address base of the frame.|  
|[IDiaStackFrame::get_cplusplusExceptionHandling](../vs140/idiastackframe--get_cplusplusexceptionhandling.md)|Retrieves a flag indicating that C++ exception handling is in effect.|  
|[IDiaStackFrame::get_functionStart](../vs140/idiastackframe--get_functionstart.md)|Retrieves a flag indicating that the block contains the entry point of a function.|  
|[IDiaStackFrame::get_lengthLocals](../vs140/idiastackframe--get_lengthlocals.md)|Retrieves the number of bytes of local variables pushed on the stack.|  
|[IDiaStackFrame::get_lengthParams](../vs140/idiastackframe--get_lengthparams.md)|Retrieves the number of bytes of parameters pushed on the stack.|  
|[IDiaStackFrame::get_lengthProlog](../vs140/idiastackframe--get_lengthprolog.md)|Retrieves the number of bytes of prologue code in the block|  
|[IDiaStackFrame::get_lengthSavedRegisters](../vs140/idiastackframe--get_lengthsavedregisters.md)|Retrieves the number of bytes of saved registers pushed on the stack.|  
|[IDiaStackFrame::get_localsBase](../vs140/idiastackframe--get_localsbase.md)|Retrieves the address base of the locals.|  
|[IDiaStackFrame::get_maxStack](../vs140/idiastackframe--get_maxstack.md)|Retrieves the maximum number of bytes pushed on the stack in the frame.|  
|[IDiaStackFrame::get_rawLVarInstanceValue](../vs140/idiastackframe--get_rawlvarinstancevalue.md)|Retrieves the value of the specified local variable as raw bytes.|  
|[registerValue](../vs140/idiastackframe--get_registervalue.md)|Retrieves the value of a specified register.|  
|[IDiaStackFrame::get_returnAddress](../vs140/idiastackframe--get_returnaddress.md)|Retrieves the return address of the frame.|  
|[IDiaStackFrame::get_size](../vs140/idiastackframe--get_size.md)|Retrieves the size of the frame in bytes.|  
|[IDiaStackFrame::get_systemExceptionHandling](../vs140/idiastackframe--get_systemexceptionhandling.md)|Retrieves a flag indicating that system exception handling is in effect.|  
|[IDiaStackFrame::get_type](../vs140/idiastackframe--get_type.md)|Retrieves the frame type.|  
  
## Remarks  
 A stack frame is an abstraction of a function call during its execution.  
  
## Notes for Callers  
 Obtain this interface by calling the [IDiaEnumStackFrames::Next](../vs140/idiaenumstackframes--next.md) method. See the [IDiaEnumStackFrames](../vs140/idiaenumstackframes.md) interface for an example on obtaining the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> interface.  
  
## Example  
 This example displays various attributes of a stack frame.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../vs140/interfaces--debug-interface-access-sdk-.md)   
 [IDiaEnumStackFrames](../vs140/idiaenumstackframes.md)   
 [IDiaEnumStackFrames::Next](../vs140/idiaenumstackframes--next.md)   
 [IDiaStackWalkFrame](../vs140/idiastackwalkframe.md)