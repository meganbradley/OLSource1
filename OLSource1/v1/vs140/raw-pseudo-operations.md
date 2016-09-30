---
title: "Raw Pseudo Operations"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: 4def1a0e-ec28-4736-91fb-fac95fba1f36
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Raw Pseudo Operations
This topic lists the pseudo operations.  
  
## Remarks  
  
|Pseudo operation|Description|  
|----------------------|-----------------|  
|PROC FRAME [:ehandler]|Causes MASM to generate a function table entry in .pdata and unwind information in .xdata for a function's structured exception handling unwind behavior.  If ehandler is present, this proc is entered in the .xdata as the language specific handler.\<br />\<br /> When the FRAME attribute is used, it must be followed by an .ENDPROLOG directive.  If the function is a leaf function (as defined in [Function Types](../vs140/function-types.md)) the FRAME attribute is unnecessary, as are the remainder of these pseudo-operations.|  
|.PUSHREG reg|Generates a UWOP_PUSH_NONVOL unwind code entry for the specified register number using the current offset in the prologue.\<br />\<br /> This should only be used with nonvolatile integer registers.  For pushes of volatile registers, use an .ALLOCSTACK 8, instead|  
|.SETFRAME reg, offset|Fills in the frame register field and offset in the unwind information using the specified register and offset. The offset must be a multiple of 16 and less than or equal to 240. This directive also generates a UWOP_SET_FPREG unwind code entry for the specified register using the current prologue offset.|  
|.ALLOCSTACK size|Generates a UWOP_ALLOC_SMALL or a UWOP_ALLOC_LARGE with the specified size for the current offset in the prologue.\<br />\<br /> The size operand must be a multiple of 8.|  
|.SAVEREG reg, offset|Generates either a UWOP_SAVE_NONVOL or a UWOP_SAVE_NONVOL_FAR unwind code entry for the specified register and offset using the current prologue offset. MASM will choose the most efficient encoding.\<br />\<br /> Offset must be positive, and a multiple of 8.  Offset is relative to the base of the procedure’s frame, which is generally in RSP, or, if using a frame pointer, the unscaled frame pointer.|  
|.SAVEXMM128 reg, offset|Generates either a UWOP_SAVE_XMM128 or a UWOP_SAVE_XMM128_FAR unwind code entry for the specified XMM register and offset using the current prologue offset. MASM will choose the most efficient encoding.\<br />\<br /> Offset must be positive, and a multiple of 16.  Offset is relative to the base of the procedure’s frame, which is generally in RSP, or, if using a frame pointer, the unscaled frame pointer.|  
|.PUSHFRAME [code]|Generates a UWOP_PUSH_MACHFRAME unwind code entry. If the optional code is specified, the unwind code entry is given a modifier of 1. Otherwise the modifier is 0.|  
|.ENDPROLOG|Signals the end of the prologue declarations.  Must occur in the first 255 bytes of the function.|  
  
 Here is a sample function prolog with proper usage of most of the opcodes:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Unwind Helpers for MASM](../vs140/unwind-helpers-for-masm.md)