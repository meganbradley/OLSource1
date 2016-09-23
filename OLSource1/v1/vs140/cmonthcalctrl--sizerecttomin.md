---
title: "CMonthCalCtrl::SizeRectToMin"
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
  - SizeRectToMin method
  - CMonthCalCtrl.SizeRectToMin
  - CMonthCalCtrl::SizeRectToMin
dev_langs: 
  - C++
helpviewer_keywords: 
  - SizeRectToMin method
ms.assetid: 318bbbe0-ea74-4f0c-bc12-408ed79600bc
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMonthCalCtrl::SizeRectToMin
For the current month calendar control, calculates the smallest rectangle that can contain all the calendars that fit in a specified rectangle.  
  
## Syntax  
  
```  
LPRECT SizeRectToMin(  
       LPRECT lpRect  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `lpRect`|Pointer to a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure that defines a rectangle that contains the desired number of calendars.|  
  
## Return Value  
 Pointer to a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure that defines a rectangle whose size is less than or equal to the rectangle defined by the `lpRect` parameter.  
  
## Remarks  
 This method calculates how many calendars can fit in the rectangle specified by the `lpRect` parameter, and then returns the smallest rectangle that can contain that number of calendars. In effect, this method shrinks the specified rectangle to exactly fit the desired number of calendars.  
  
 This method sends the [MCM_SIZERECTTOMIN](http://msdn.microsoft.com/library/windows/desktop/bb761020) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxdtctl.h  
  
 This control is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CMonthCalCtrl Class](../vs140/cmonthcalctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [MCM_SIZERECTTOMIN](http://msdn.microsoft.com/library/windows/desktop/bb761020)   
 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897)