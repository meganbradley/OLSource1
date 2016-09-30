---
title: "unique_ptr::release"
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
  - "release"
  - "std.unique_ptr.release"
  - "std::unique_ptr::release"
  - "unique_ptr.release"
  - "memory/std::unique_ptr::release"
  - "unique_ptr::release"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "release method"
ms.assetid: ca050c71-da7d-4598-a8d7-3af9a602cdbc
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unique_ptr::release
Releases ownership of the returned stored pointer to the caller and sets the stored pointer value to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Property Value/Return Value  
 Returns the stored pointer.  
  
## Remarks  
 Use <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to take over ownership of the raw pointer stored by the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. The caller is responsible for deletion of the returned pointer. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is set to the empty default-constructed state. You can assign another pointer of compatible type to the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> after the call to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Example  
 This example shows how the caller of release is responsible for the object returned:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Computer output:  
  
 **Constructing Sample(3)**  
**Constructing Sample(42)**  
**Deleting Sample(42)**  
**Deleting Sample(3)**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [unique_ptr](../vs140/unique_ptr-class.md)   
 [How to: Create and Use unique_ptr Instances](../vs140/how-to--create-and-use-unique_ptr-instances.md)   
 [\<memory>](../vs140/-memory-.md)