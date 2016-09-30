---
title: "IDiaFrameData"
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
  - "IDiaFrameData interface"
ms.assetid: 2f1b4986-341b-4641-89a4-226e261e9d93
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaFrameData
Exposes the details of a stack frame.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Methods in Vtable Order  
 The following table shows the methods of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaFrameData::get_addressSection](../vs140/idiaframedata--get_addresssection.md)|Retrieves the section part of the code address for the frame.|  
|[IDiaFrameData::get_addressOffset](../vs140/idiaframedata--get_addressoffset.md)|Retrieves the offset part of the code address for the frame.|  
|[IDiaFrameData::get_relativeVirtualAddress](../vs140/idiaframedata--get_relativevirtualaddress.md)|Retrieves the image relative virtual address (RVA) of the code for the frame.|  
|[IDiaFrameData::get_virtualAddress](../vs140/idiaframedata--get_virtualaddress.md)|Retrieves the virtual address (VA) of the code for the frame.|  
|[IDiaFrameData::get_lengthBlock](../vs140/idiaframedata--get_lengthblock.md)|Retrieves the length, in bytes, of the block of code described by the frame.|  
|[IDiaFrameData::get_lengthLocals](../vs140/idiaframedata--get_lengthlocals.md)|Retrieves the number of bytes of local variables pushed on the stack.|  
|[IDiaFrameData::get_lengthParams](../vs140/idiaframedata--get_lengthparams.md)|Retrieves the number of bytes of parameters pushed on the stack.|  
|[IDiaFrameData::get_maxStack](../vs140/idiaframedata--get_maxstack.md)|Retrieves the maximum number of bytes pushed on the stack in the frame.|  
|[IDiaFrameData::get_lengthProlog](../vs140/idiaframedata--get_lengthprolog.md)|Retrieves the number of bytes of prologue code in the block.|  
|[IDiaFrameData::get_lengthSavedRegisters](../vs140/idiaframedata--get_lengthsavedregisters.md)|Retrieves the number of bytes of saved registers pushed on the stack.|  
|[IDiaFrameData::get_program](../vs140/idiaframedata--get_program.md)|Retrieves the program string that is used to compute the register set before the call to the current function.|  
|[IDiaFrameData::get_systemExceptionHandling](../vs140/idiaframedata--get_systemexceptionhandling.md)|Retrieves a flag that indicates that system exception handling is in effect.|  
|[IDiaFrameData::get_cplusplusExceptionHandling](../vs140/idiaframedata--get_cplusplusexceptionhandling.md)|Retrieves a flag that indicates that C++ exception handling is in effect.|  
|[IDiaFrameData::get_functionStart](../vs140/idiaframedata--get_functionstart.md)|Retrieves a flag that indicates that the block contains the entry point of a function.|  
|[IDiaFrameData::get_allocatesBasePointer](../vs140/idiaframedata--get_allocatesbasepointer.md)|Retrieves a flag that indicates that the base pointer is allocated for code in this address range. This method is deprecated.|  
|[IDiaFrameData::get_type](../vs140/idiaframedata--get_type.md)|Retrieves the compiler-specific frame type.|  
|[IDiaFrameData::get_functionParent](../vs140/idiaframedata--get_functionparent.md)|Retrieves frame data interface for enclosing function.|  
|[IDiaFrameData::execute](../vs140/idiaframedata--execute.md)|Performs stack unwinding and returns the current state of registers in a stack walk frame interface.|  
  
## Remarks  
 The details available for a frame are for execution points within the address range indicated by the address and block length.  
  
## Notes for Callers  
 Obtain this interface by calling the [IDiaEnumFrameData::Next](../vs140/idiaenumframedata--next.md) or [IDiaEnumFrameData::Item](../vs140/idiaenumframedata--item.md) methods. See the [IDiaEnumFrameData](../vs140/idiaenumframedata.md) interface for details.  
  
## Example  
 This example prints out the properties of an <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object. See the [IDiaEnumFrameData](../vs140/idiaenumframedata.md) interface for an example of how the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> interface is obtained.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../vs140/interfaces--debug-interface-access-sdk-.md)   
 [IDiaEnumFrameData](../vs140/idiaenumframedata.md)   
 [IDiaEnumFrameData::Item](../vs140/idiaenumframedata--item.md)   
 [IDiaEnumFrameData::Next](../vs140/idiaenumframedata--next.md)