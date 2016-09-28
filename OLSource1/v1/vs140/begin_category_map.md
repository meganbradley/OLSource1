---
title: "BEGIN_CATEGORY_MAP"
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
  - "BEGIN_CATEGORY_MAP"
  - "ATL.BEGIN_CATEGORY_MAP"
  - "ATL::BEGIN_CATEGORY_MAP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "category maps"
  - "BEGIN_CATEGORY_MAP macro"
ms.assetid: 55bee409-be14-457f-8df8-b8900eba48cb
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BEGIN_CATEGORY_MAP
Marks the beginning of the category map.  
  
## Syntax  
  
```  
  
BEGIN_CATEGORY_MAP( theClass )  
```  
  
#### Parameters  
 `theClass`  
 [in] The name of the class containing the category map.  
  
## Remarks  
 The category map is used to specify which component categories the COM class will implement and which categories it requires from its container.  
  
 Add an [IMPLEMENTED_CATEGORY](../vs140/implemented_category.md) entry to the map for each category implemented by the COM class. Add a [REQUIRED_CATEGORY](../vs140/required_category.md) entry to the map for each category that the class requires its clients to implement. Mark the end of the map with the [END_CATEGORY_MAP](../vs140/end_category_map.md) macro.  
  
 The component categories listed in the map will be registered automatically when the module is registered if the class has an associated [OBJECT_ENTRY_AUTO](../vs140/object_entry_auto.md) or [OBJECT_ENTRY_NON_CREATEABLE_EX_AUTO](../vs140/object_entry_non_createable_ex_auto.md).  
  
> [!NOTE]
>  ATL uses the standard component categories manager to register component categories. If the manager is not present on the system when the module is registered, registration succeeds, but the component categories will not be registered for that class.  
  
 For more information about component categories, see [What are Component Categories and how do they work?](http://msdn.microsoft.com/library/windows/desktop/ms694322) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_ATL_Windowing#100](../vs140/codesnippet/CPP/begin_category_map_1.h)]  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [Category Macros](../vs140/category-macros.md)   
 [Macros](../vs140/atl-macros.md)   
 [IMPLEMENTED_CATEGORY](../vs140/implemented_category.md)   
 [REQUIRED_CATEGORY](../vs140/required_category.md)   
 [END_CATEGORY_MAP](../vs140/end_category_map.md)