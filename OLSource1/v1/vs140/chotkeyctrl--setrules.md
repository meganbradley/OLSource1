---
title: "CHotKeyCtrl::SetRules"
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
  - "HKCOMB_A"
  - "HKCOMB_C"
  - "HKCOMB_SA"
  - "CHotKeyCtrl.SetRules"
  - "HKCOMB_SC"
  - "HKCOMB_NONE"
  - "HKCOMB_SCA"
  - "HKCOMB_S"
  - "SetRules"
  - "HKCOMB_CA"
  - "CHotKeyCtrl::SetRules"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HKCOMB_CA"
  - "HKCOMB_A"
  - "HKCOMB_SC"
  - "HKCOMB_S"
  - "HKCOMB_NONE"
  - "HKCOMB_SA"
  - "HKCOMB_C"
  - "SetRules method"
  - "HKCOMB_SCA"
ms.assetid: 26f5be4e-b3be-4f5c-b384-8fe567984876
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHotKeyCtrl::SetRules
Call this function to define the invalid combinations and the default modifier combination for a hot key control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Array of flags that specifies invalid key combinations. It can be a combination of the following values:  
  
-   <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> ALT  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> CTRL  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> CTRL+ALT  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> Unmodified keys  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> SHIFT  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> SHIFT+ALT  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> SHIFT+CTRL  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> SHIFT+CTRL+ALT  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Array of flags that specifies the key combination to use when the user enters an invalid combination. For more information on the modifier flags, see [GetHotKey](../vs140/chotkeyctrl--gethotkey.md).  
  
## Remarks  
 When a user enters an invalid key combination, as defined by flags specified in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, the system uses the OR operator to combine the keys entered by the user with the flags specified in <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. The resulting key combination is converted into a string and then displayed in the hot key control.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CHotKeyCtrl Class](../vs140/chotkeyctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHotKeyCtrl::GetHotKey](../vs140/chotkeyctrl--gethotkey.md)   
 [CHotKeyCtrl::SetHotKey](../vs140/chotkeyctrl--sethotkey.md)