---
title: "auto_gcroot::attach"
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
  - "auto_gcroot.attach"
  - "auto_gcroot::attach"
  - "msclr::auto_gcroot::attach"
  - "msclr.auto_gcroot.attach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "auto_gcroot::attach"
ms.assetid: 996ede65-bcb5-41f2-bfbf-507f8a578241
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# auto_gcroot::attach
Attach <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to an object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The object to attach, or an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> containing the object to attach.  
  
## Return Value  
 The current <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is an <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, it releases ownership of its object before the object is attached to the current <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **in ClassA constructor:first**  
**Hello from first A!**  
**in ClassA constructor:second**  
**in ClassA destructor:first**  
**Hello from second A!**  
**in ClassA constructor:third**  
**in ClassA destructor:second**  
**Hello from third A!**  
**in ClassA constructor:fourth**  
**Hello from fourth B!**  
**in ClassA destructor:third**  
**Hello from fourth A!**  
**in ClassA destructor:fourth**   
## Requirements  
 **Header file** \<msclr\auto_gcroot.h>  
  
 **Namespace** msclr  
  
## See Also  
 [auto_gcroot Members](../vs140/auto_gcroot-members.md)   
 [auto_gcroot::operator=](../vs140/auto_gcroot--operator=.md)   
 [auto_gcroot::release](../vs140/auto_gcroot--release.md)