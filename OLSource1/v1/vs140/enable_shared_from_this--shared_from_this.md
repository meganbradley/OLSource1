---
title: "enable_shared_from_this::shared_from_this"
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
  - "enable_shared_from_this.shared_from_this"
  - "tr1::enable_shared_from_this::shared_from_this"
  - "tr1.enable_shared_from_this.shared_from_this"
  - "std::tr1::enable_shared_from_this::shared_from_this"
  - "enable_shared_from_this::shared_from_this"
  - "std.tr1.enable_shared_from_this.shared_from_this"
  - "shared_from_this"
  - "memory/std::tr1::enable_shared_from_this::shared_from_this"
  - "std.enable_shared_from_this.shared_from_this"
  - "std::enable_shared_from_this::shared_from_this"
  - "memory/std::enable_shared_from_this::shared_from_this"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "shared_from_this method"
  - "shared_from_this method [TR1]"
ms.assetid: e3465b8e-d61a-4873-aa05-0b657e29fe48
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# enable_shared_from_this::shared_from_this
Generates a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> that shares ownership of the instance with existing <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> owners.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 When you derive objects from the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> base class, the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> template member functions return a [shared_ptr](../vs140/shared_ptr-class.md) object that shares ownership of this instance with existing <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> owners. Otherwise, if you create a new <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> from <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, it is distinct from existing <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> owners, which can lead to invalid references or cause the object to be deleted more than once. The  behavior is undefined if you call <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> on an instance that is not already owned by a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **sp2->val == 3**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [enable_shared_from_this](../vs140/enable_shared_from_this-class.md)