---
title: "ref new, gcnew  (C++ Component Extensions)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "gcnew"
  - "ref new"
  - "gcnew_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ref new keyword (C++)"
  - "gcnew keyword [C++]"
ms.assetid: 388a62da-c2df-4a94-a9a2-205b53e577da
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ref new, gcnew  (C++ Component Extensions)
The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> aggregate keyword allocates an instance of a type that is garbage collected when the object becomes inaccessible, and that returns a handle ([^](../vs140/handle-to-object-operator--^----c---component-extensions-.md)) to the allocated object.  
  
## All Runtimes  
 Memory for an instance of a type that is allocated by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is deallocated automatically.  
  
 A <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> operation throws <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if it is unable to allocate memory.  
  
 For more information about how memory for native C++ types is allocated and deallocated, see [the new and delete operators](../vs140/new-and-delete-operators.md).  
  
## [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]  
 Use <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to allocate memory for Windows Runtime objects whose lifetime you want to administer automatically. The object is automatically deallocated when its reference count goes to zero, which occurs after the last copy of the reference has gone out of scope. For more information, see [Ref classes and structs](http://msdn.microsoft.com/library/windows/apps/hh699870.aspx).  
  
### Requirements  
 Compiler option: **/ZW**  
  
## [!INCLUDE[clr_for_headings](../vs140/includes/clr_for_headings_md.md)]  
 Memory for a managed type (reference or value type) is allocated by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and deallocated by using garbage collection.  
  
### Requirements  
 Compiler option: **/clr**  
  
### Examples  
 **Example**  
  
 The following example uses <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to allocate a Message object.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Example**  
  
 The following example uses <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to create a boxed value type for use like a reference type.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Output**  
  
 **32**   
## See Also  
 [Language Extensions for Runtime Platforms](../vs140/component-extensions-for-runtime-platforms.md)