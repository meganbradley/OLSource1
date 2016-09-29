---
title: "REQUIRED_CATEGORY"
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
  - "REQUIRED_CATEGORY"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "REQUIRED_CATEGORY macro"
ms.assetid: 55100145-9e6f-4824-bb1a-5df8a67f6fb8
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# REQUIRED_CATEGORY
Add a `REQUIRED_CATEGORY` macro to your component's [category map](../vs140/begin_category_map.md) to specify that it should be registered as requiring the category identified by the `catID` parameter.  
  
## Syntax  
  
```  
  
      REQUIRED_CATEGORY(   
   catID    
)  
```  
  
#### Parameters  
 `catID`  
 [in] A **CATID** constant or variable holding the globally unique identifier (GUID) for the required category. The address of `catID` will be taken and added to the map. See the table below for a selection of stock categories.  
  
## Remarks  
 The component categories listed in the map will be registered automatically when the module is registered if the class has an associated [OBJECT_ENTRY_AUTO](../vs140/object_entry_auto.md) or [OBJECT_ENTRY_NON_CREATEABLE_EX_AUTO](../vs140/object_entry_non_createable_ex_auto.md) macro.  
  
 Clients can use the category information registered for the class to determine its capabilities and requirements without having to create an instance of it. For example, a control may require that a container support data binding. The container can find out if it has the capabilities necessary to host the control by querying the category manager for the categories required by that control. If the container does not support a required feature, it can refuse to host the COM object.  
  
 For more information about component categories, including a sample list, see [What are Component Categories and how do they work?](http://msdn.microsoft.com/library/windows/desktop/ms694322) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### A Selection of Stock Categories  
  
|Description|Symbol|Registry GUID|  
|-----------------|------------|-------------------|  
|Safe For Scripting|CATID_SafeForScripting|{7DD95801-9882-11CF-9FA9-00AA006C42C4}|  
|Safe For Initialization|CATID_SafeForInitializing|{7DD95802-9882-11CF-9FA9-00AA006C42C4}|  
|Simple Frame Site Containment|CATID_SimpleFrameControl|{157083E0-2368-11cf-87B9-00AA006C8166}|  
|Simple Data Binding|CATID_PropertyNotifyControl|{157083E1-2368-11cf-87B9-00AA006C8166}|  
|Advanced Data Binding|CATID_VBDataBound|{157083E2-2368-11cf-87B9-00AA006C8166}|  
|Windowless Controls|CATID_WindowlessObject|{1D06B600-3AE3-11cf-87B9-00AA006C8166}|  
|Internet-Aware Objects|See [Internet Aware Objects](http://msdn.microsoft.com/library/windows/desktop/ms690561) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a sample list.||  
  
## Example  
 [!code[NVC_ATL_Windowing#135](../vs140/codesnippet/CPP/required_category_1.h)]  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [Category Macros](../vs140/category-macros.md)   
 [Macros](../vs140/atl-macros.md)   
 [BEGIN_CATEGORY_MAP](../vs140/begin_category_map.md)   
 [IMPLEMENTED_CATEGORY](../vs140/implemented_category.md)   
 [END_CATEGORY_MAP](../vs140/end_category_map.md)