---
title: "CSplitButton::CSplitButton"
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
  - "CSplitButton::CSplitButton"
  - "CSplitButton constructor"
  - "CSplitButton.CSplitButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSplitButton constructor"
ms.assetid: 82c3d009-2138-406f-9e74-cf7319931deb
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSplitButton::CSplitButton
Constructs a `CSplitButton` object. The constructor's parameters specify a submenu that is displayed when a user clicks the drop-down arrow of the split button control.  
  
## Syntax  
  
```  
CSplitButton();  
CSplitButton(  
    UINT nMenuId,   
    UINT nSubMenuId  
)  
CSplitButton(  
    CMenu* pMenu  
)  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `nMenuId`|The resource ID of the menu bar.|  
|[in] `nSubMenuId`|The resource ID of a submenu.|  
|[in] `pMenu`|A pointer to a [CMenu](../vs140/cmenu-class.md) object that specifies a submenu. The `CSplitButton` object deletes the `CMenu` object and its associated `HMENU` when the `CSplitButton` object goes out of scope.|  
  
## Remarks  
 Use the [CSplitButton::Create](../vs140/csplitbutton--create.md) method to create a split button control and attach it to the `CSplitButton` object.  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CSplitButton Class](../vs140/csplitbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSplitButton::Create](../vs140/csplitbutton--create.md)