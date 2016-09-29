---
title: "accelerator::set_default Method"
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
  - "amprt/Concurrency::accelerator::set_default"
dev_langs: 
  - "C++"
ms.assetid: 9863e4b2-35b4-4b14-b40c-917dd266605b
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# accelerator::set_default Method
Sets the default accelerator to be used for any operation that implicitly uses the default accelerator. This method only succeeds if the runtime selected default accelerator has not already been used in an operation that implicitly uses the default accelerator  
  
## Syntax  
  
```  
static inline bool set_default(  
   std::wstring _Path  
);  
```  
  
#### Parameters  
 `_Path`  
 The path to the accelerator.  
  
## Return Value  
 `true` if the call succeeds at setting the default accelerator. Otherwise, `false`.  
  
## Remarks  
 The C++ AMP runtime picks a default accelerator, unless you write code to pick a specific accelerator. For more information, see [Using accelerator and accelerator_view objects](../VS_csharp/using-accelerator-and-accelerator_view-objects.md).  
  
 You can specify the default accelerator object in these ways:  
  
1.  Call the constructor that takes a device path parameter.  
  
2.  Set the default accelerator using the [accelerator::set_default Method](../VS_csharp/accelerator--set_default-method.md) and pass the value of [accelerator::default_accelerator Data Member](../VS_csharp/accelerator--default_accelerator-data-member.md) to the constructor.  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [accelerator Class](../VS_csharp/accelerator-class.md)   
 [Using accelerator and accelerator_view objects](../VS_csharp/using-accelerator-and-accelerator_view-objects.md)