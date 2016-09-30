---
title: "CDateTimeCtrl::GetDateTimePickerInfo"
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
  - "GetDateTimePickerInfo method"
  - "CDateTimeCtrl::GetDateTimePickerInfo"
  - "CDateTimeCtrl.GetDateTimePickerInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDateTimePickerInfo method"
ms.assetid: effe8791-f4e8-4499-90b8-e96b8c8ad691
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDateTimeCtrl::GetDateTimePickerInfo
Retrieves information about the current date and time picker control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|A pointer to a [DATETIMEPICKERINFO](http://msdn.microsoft.com/library/windows/desktop/bb761729) structure that receives a description of the current date and time picker control.\<br />\<br /> The caller is responsible for allocating this structure. However, this method initializes the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> member of the structure.|  
  
## Return Value  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method sends the [DTM_GETDATETIMEPICKERINFO](http://msdn.microsoft.com/library/windows/desktop/bb761755) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 The following code example defines the variable, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, that is used to programmatically access the date and time picker control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CDateTimeCtrl_s1#1](../vs140/codesnippet/CPP/cdatetimectrl--getdatetimepickerinfo_1.h)]  
  
## Example  
 The following code example indicates whether it successfully retrieves information about the current date and time picker control.  
  
 [!code[NVC_MFC_CDateTimeCtrl_s1#4](../vs140/codesnippet/CPP/cdatetimectrl--getdatetimepickerinfo_2.cpp)]  
  
## Requirements  
 **Header:** afxdtctl.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
## See Also  
 [CDateTimeCtrl Class](../vs140/cdatetimectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [DTM_GETDATETIMEPICKERINFO](http://msdn.microsoft.com/library/windows/desktop/bb761755)   
 [DATETIMEPICKERINFO](http://msdn.microsoft.com/library/windows/desktop/bb761729)