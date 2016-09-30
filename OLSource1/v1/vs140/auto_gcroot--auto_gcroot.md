---
title: "auto_gcroot::auto_gcroot"
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
  - "msclr::auto_gcroot::auto_gcroot"
  - "auto_gcroot::auto_gcroot"
  - "auto_gcroot.auto_gcroot"
  - "msclr.auto_gcroot.auto_gcroot"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "auto_gcroot::auto_gcroot"
ms.assetid: 27faa42a-64ea-4d31-836f-073a55145735
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# auto_gcroot::auto_gcroot
The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> constructor.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The object to own.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An existing <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 When constructing an <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> from an existing <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, the existing <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> releases its object before transferring ownership of the object to the new <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **in RefClassA constructor: unmanaged**  
**Hello from unmanaged A!**  
**in RefClassA destructor: unmanaged**  
**in RefClassA constructor: first**  
**Hello from first A!**  
**in RefClassA destructor: first**  
**in RefClassA constructor: second**  
**Hello from second B!**  
**Hello from second A!**  
**Hello from second A!**  
**in RefClassA destructor: second**  
**done**   
## Requirements  
 **Header file** \<msclr\auto_gcroot.h>  
  
 **Namespace** msclr  
  
## See Also  
 [auto_gcroot Members](../vs140/auto_gcroot-members.md)   
 [auto_gcroot::attach](../vs140/auto_gcroot--attach.md)   
 [auto_gcroot::operator=](../vs140/auto_gcroot--operator=.md)   
 [auto_gcroot::~auto_gcroot](../vs140/auto_gcroot--~auto_gcroot.md)