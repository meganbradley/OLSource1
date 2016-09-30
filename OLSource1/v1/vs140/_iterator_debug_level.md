---
title: "_ITERATOR_DEBUG_LEVEL"
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
  - "_ITERATOR_DEBUG_LEVEL"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_ITERATOR_DEBUG_LEVEL"
ms.assetid: 718549cd-a9a9-4ab3-867b-aac00b321e67
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _ITERATOR_DEBUG_LEVEL
The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> (IDL) macro supersedes and combines the functionality of the [_SECURE_SCL](../vs140/_secure_scl.md) (SCL) and [_HAS_ITERATOR_DEBUGGING](../vs140/_has_iterator_debugging.md) (HID) macros.  
  
## Macro Values  
 The following tables summarize the values for the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> macros, and finally how those values are superseded by the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> macro.  
  
 The following section describes the possible values of the SCL and HID macros.  
  
 SCL=0  
 Disables checked iterators.  
  
 SCL=1  
 Enables checked iterators.  
  
 HID=0  
 Disables iterator debugging in debug builds.  
  
 HID=1  
 Enables iterator debugging in debug builds. HID cannot be enabled in release builds.  
  
 The following table describes how the IDL macro values supersede the SCL and HID macro values.  
  
|Compilation mode|New macro|Old macros|Description|  
|----------------------|---------------|----------------|-----------------|  
|**Debug**||||  
||IDL=0|SCL=0, HID=0|Disables checked iterators and disables iterator debugging.|  
||IDL=1|SCL=1, HID=0|Enables checked iterators and disables iterator debugging.|  
||IDL=2 (Default)|SCL=(does not apply), HID=1|By default, enables iterator debugging; checked iterators are not relevant.|  
|**Release**||||  
||IDL=0 (Default)|SCL=0|By default, disables checked iterators.|  
||IDL=1|SCL=1|Enables checked iterators; iterator debugging is not relevant.|  
  
## Remarks  
 In release mode, an error is emitted if you specify IDL=2.  
  
 Because the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> macros support similar functionality, users are often uncertain which macro and macro value to use in a particular situation. To resolve this issue, we recommend that you use only the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> macro.  
  
## See Also  
 [Safe Libraries: Standard C++ Library](../vs140/safe-libraries--c---standard-library.md)