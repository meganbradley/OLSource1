---
title: "auto_gcroot::operator="
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "auto_gcroot.operator="
  - "msclr::auto_gcroot::operator="
  - "msclr.auto_gcroot.operator="
  - "auto_gcroot::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator="
ms.assetid: 99eba5eb-5a2c-4edf-b3d5-c903f818233d
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# auto_gcroot::operator=
Assignment operator.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The object or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to be assigned to the current <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Return Value  
 The current <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, now owning <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **in ClassA constructor: first**  
**Hello from first A!**  
**in ClassA constructor: second**  
**in ClassA destructor: first**  
**in ClassA constructor: third**  
**Hello from third B!**  
**in ClassA destructor: second**  
**Hello from third A!**  
**done**  
**in ClassA destructor: third**   
## Requirements  
 **Header file** \<msclr\auto_gcroot.h>  
  
 **Namespace** msclr  
  
## See Also  
 [auto_gcroot Members](../vs140/auto_gcroot-members.md)   
 [auto_gcroot::attach](../vs140/auto_gcroot--attach.md)