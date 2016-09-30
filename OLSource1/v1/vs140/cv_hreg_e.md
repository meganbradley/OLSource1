---
title: "CV_HREG_e"
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
  - "CV_HREG_e enumeration"
ms.assetid: 3f0622f7-6790-41d8-8778-227cbbf8a212
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CV_HREG_e
Specifies a target register.  
  
> [!NOTE]
>  Because the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> enumeration is too large to duplicate in its entirety here, an abbreviated version is provided as a reference. Missing entries are notated in italics. The complete enumeration is available in the cvconst.h header file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Elements  
 CV_REG_*  
 Registers used by Intel 80x86 and ix86 processors, and p-code.  
  
 CV_R68_*  
 Registers used by 68K processor.  
  
 CV_M4_*  
 Registers used by MIPS 4000 series processor.  
  
 CV_ALPHA_*  
 Registers used by Digital Equipment Corporation Alpha AXP series processor.  
  
 CV_PPC_*  
 Registers used by Motorola/IBM PowerPC processor.  
  
 CV_SH3_* and CV_SH_\*  
 Registers used by Hitachi SH3 and Hitachi SH series processor.  
  
 CV_ARM_*  
 Registers used by Advanced RISC Machine (ARM) processors.  
  
 CV_IA64_*  
 Registers used by Intel IA64 series processors.  
  
 CV_TRI_*  
 Registers used by Infineon Technologies TriCore processor.  
  
 CV_AM33_*  
 Registers used by Matsushita/Panasonic AM33 and related processors.  
  
 CV_M32R_*  
 Registers used by Mitsubishi M32R processor.  
  
## Remarks  
 Each processor type uses its own unique set of registers.  
  
 The values in this enumeration are passed to the following methods:  
  
-   [IDiaStackWalkFrame::get_registerValue](../vs140/idiastackwalkframe--get_registervalue.md)  
  
-   [IDiaStackWalkFrame::put_registerValue](../vs140/idiastackwalkframe--put_registervalue.md)  
  
-   [IDiaStackWalkHelper::get_registerValue](../vs140/idiastackwalkhelper--get_registervalue.md)  
  
-   [IDiaStackWalkHelper::put_registerValue](../vs140/idiastackwalkhelper--put_registervalue.md)  
  
-   [IDiaStackFrame::get_registerValue](../vs140/idiastackframe--get_registervalue.md)  
  
## Requirements:  
 Header: cvconst.h  
  
## See Also  
 [Enumerations and Structures](../vs140/enumerations-and-structures.md)   
 [IDiaStackWalkFrame::get_registerValue](../vs140/idiastackwalkframe--get_registervalue.md)   
 [IDiaStackWalkFrame::put_registerValue](../vs140/idiastackwalkframe--put_registervalue.md)   
 [IDiaStackWalkHelper::get_registerValue](../vs140/idiastackwalkhelper--get_registervalue.md)   
 [IDiaStackWalkHelper::put_registerValue](../vs140/idiastackwalkhelper--put_registervalue.md)   
 [IDiaStackFrame::get_registerValue](../vs140/idiastackframe--get_registervalue.md)