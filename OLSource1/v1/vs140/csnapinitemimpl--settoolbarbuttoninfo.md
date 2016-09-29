---
title: "CSnapInItemImpl::SetToolbarButtonInfo"
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
  - "CSnapInItemImpl.SetToolbarButtonInfo"
  - "CSnapInItemImpl::SetToolbarButtonInfo"
  - "SetToolbarButtonInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetToolbarButtonInfo method"
ms.assetid: aee09ce5-6783-437b-98a3-e4a6938bc260
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSnapInItemImpl::SetToolbarButtonInfo
Call this function to modify any toolbar button styles, of the snap-in object, before the toolbar is created.  
  
## Syntax  
  
```  
  
      void SetToolbarButtonInfo(  
   UINT id,  
   BYTE *fsState,  
   BYTE *fsType   
);  
```  
  
#### Parameters  
 `id`  
 [in] The ID of the toolbar button to be set.  
  
 `fsState`  
 [in] The state flags of the button. Can be one or more of the following:  
  
-   `TBSTATE_CHECKED` The button has the **TBSTYLE_CHECKED** style and is being pressed.  
  
-   `TBSTATE_ENABLED` The button accepts user input. A button that does not have this state does not accept user input and is grayed.  
  
-   `TBSTATE_HIDDEN` The button is not visible and cannot receive user input.  
  
-   `TBSTATE_INDETERMINATE` The button is grayed.  
  
-   `TBSTATE_PRESSED` The button is being pressed.  
  
-   `TBSTATE_WRAP` A line break follows the button. The button must also have the `TBSTATE_ENABLED`.  
  
 *fsType*  
 [in] The state flags of the button. Can be one or more of the following:  
  
-   `TBSTYLE_BUTTON` Creates a standard push button.  
  
-   `TBSTYLE_CHECK` Creates a button that toggles between the pressed and not-pressed states each time the user clicks it. The button has a different background color when it is in the pressed state.  
  
-   `TBSTYLE_CHECKGROUP` Creates a check button that stays pressed until another button in the group is pressed.  
  
-   `TBSTYLE_GROUP` Creates a button that stays pressed until another button in the group is pressed.  
  
-   `TBSTYLE_SEP` Creates a separator, providing a small gap between button groups. A button that has this style does not receive user input.  
  
## Requirements  
 **Header:** atlsnap.h  
  
## See Also  
 [CSnapInItemImpl Class](../vs140/csnapinitemimpl-class.md)