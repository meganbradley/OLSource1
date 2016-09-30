---
title: "ios_base::failure"
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
  - "ios_base.failure"
  - "std::ios_base::failure"
  - "ios/std::ios_base::failure"
  - "ios_base::failure"
  - "failure"
  - "std.ios_base.failure"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "failure method"
ms.assetid: f8578c47-c17e-4dae-80dd-1e710fe26e7f
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ios_base::failure
The class <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> defines the base class for the types of all objects thrown as exceptions, by functions in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> library, to report errors detected during stream buffer operations.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The value returned by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is a copy of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, possibly augmented with a test based on <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is not specified, the default value is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Caught an exception: ios_base::failbit set**   
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [ios_base Class](../vs140/ios_base-class.md)   
 [system_error](../vs140/system_error-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)