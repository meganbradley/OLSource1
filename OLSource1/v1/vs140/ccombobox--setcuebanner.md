---
title: "CComboBox::SetCueBanner"
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
  - CCombobox::SetCueBanner
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetCueBanner method
ms.assetid: 25af360c-e4f0-46a6-aedd-d791c521aa0b
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComboBox::SetCueBanner
Sets the cue text that is displayed for a combo box control.  
  
## Syntax  
  
```  
BOOL SetCueBanner(  
     LPCTSTR lpszText  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] *lpszText*|Pointer to a null-terminated buffer that contains the cue text.|  
  
## Return Value  
 `true` if the method is successful; otherwise, `false`.  
  
## Remarks  
 Cue text is a prompt that is displayed in the input area of the combo box control. The cue text is displayed until the user provides input.  
  
 This method sends the [CB_SETCUEBANNER](http://msdn.microsoft.com/library/windows/desktop/bb775897) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## Example  
 The following code example defines the variable, `m_combobox`, that is used to programmatically access the combo box control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CComboBox_s1#1](../vs140/codesnippet/CPP/ccombobox--setcuebanner_1.h)]
  
  
## Example  
 The following code example sets the cue banner for the combo box control.  
  
 [!code[NVC_MFC_CComboBox_s1#2](../vs140/codesnippet/CPP/ccombobox--setcuebanner_2.cpp)]
  
  
## See Also  
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBox::GetCueBanner](../vs140/ccombobox--getcuebanner.md)   
 [CB_SETCUEBANNER](http://msdn.microsoft.com/library/windows/desktop/bb775897)