---
title: "CButton::SetElevationRequired"
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
  - "CButton.SetElevationRequired"
  - "CButton::SetElevationRequired"
  - "SetElevationRequired method"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetElevationRequired method"
ms.assetid: bc5f9c14-1f81-4df2-9058-55834ed67fc3
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CButton::SetElevationRequired
Sets the state of the current button control to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, which is necessary for the control to display an elevated security icon.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to set <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> state; otherwise, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.|  
  
## Return Value  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Remarks  
 If a button or command link control requires elevated security permission to perform an action, set the control to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> state. Subsequently, Windows displays the User Account Control (UAC) shield icon on the control. For more information, see "User Account Control" at [MSDN](http://go.microsoft.com/fwlink/?LinkId=18507).  
  
 This method sends the [BCM_SETSHIELD](http://msdn.microsoft.com/library/windows/desktop/bb775979) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CButton Class](../vs140/cbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [BCM_SETSHIELD](http://msdn.microsoft.com/library/windows/desktop/bb775979)