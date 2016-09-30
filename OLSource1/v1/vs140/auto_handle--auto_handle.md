---
title: "auto_handle::auto_handle"
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
  - "auto_handle::auto_handle"
  - "msclr.auto_handle.auto_handle"
  - "auto_handle.auto_handle"
  - "msclr::auto_handle::auto_handle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "auto_handle method"
ms.assetid: 0b68ab31-023c-4224-9601-9231412c4e13
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# auto_handle::auto_handle
The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> constructor.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The object to own.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An existing <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
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
 **Header file** \<msclr\auto_handle.h>  
  
 **Namespace** msclr  
  
## See Also  
 [auto_handle Members](../vs140/auto_handle-members.md)   
 [auto_handle::operator=](../vs140/auto_handle--operator=.md)   
 [auto_handle::~auto_handle](../vs140/auto_handle--~auto_handle.md)