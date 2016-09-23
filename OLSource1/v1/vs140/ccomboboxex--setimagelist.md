---
title: "CComboBoxEx::SetImageList"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CComboBoxEx.SetImageList
  - CComboBoxEx::SetImageList
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetImageList method
ms.assetid: 866328cf-699c-4313-8a01-ee164f9da5fb
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComboBoxEx::SetImageList
Sets an image list for a **ComboBoxEx** control.  
  
## Syntax  
  
```  
  
      CImageList* SetImageList(  
   CImageList* pImageList   
);  
```  
  
#### Parameters  
 `pImageList`  
 A pointer to a `CImageList` object containing the images to use with the `CComboBoxEx` control.  
  
## Return Value  
 A pointer to a [CImageList](../vs140/cimagelist-class.md) object containing the images previously used by the `CComboBoxEx` control. **NULL** if no image list was previously set.  
  
## Remarks  
 This member function implements the functionality of the message [CBEM_SETIMAGELIST](http://msdn.microsoft.com/library/windows/desktop/bb775787), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. If you change the height of the default edit control, call the Win32 function [SetWindowPos](http://msdn.microsoft.com/library/windows/desktop/ms633545) to resize your control after you call `SetImageList`, or it will not display properly.  
  
 The `CImageList` object pointed to by the return value is a temporary object and is destroyed during the next idle processing time.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CComboBoxEx Class](../vs140/ccomboboxex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBoxEx::GetImageList](../vs140/ccomboboxex--getimagelist.md)