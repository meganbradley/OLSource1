---
title: "CNetAddressCtrl::SetAllowType"
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
  - "SetAllowType method"
  - "CNetAddressCtrl::SetAllowType"
  - "CNetAddressCtrl.SetAllowType"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetAllowType method"
ms.assetid: f6ceed85-dfde-4b34-be56-9fb3e05198a4
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CNetAddressCtrl::SetAllowType
Sets the type of network address that the current network address control can support.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|A bitwise combination (OR) of flags that specifies the types of addresses the network address control can support. For more information, see [NET_STRING](http://msdn.microsoft.com/library/windows/desktop/bb762586).|  
  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if this method is successful; otherwise, a COM error code.  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## Remarks  
 Use the [CNetAddressCtrl::SetAllowType](../vs140/cnetaddressctrl--setallowtype.md) method to specify the types of addresses that the current network address control can support. Use the [CNetAddressCtrl::GetAddress](../vs140/cnetaddressctrl--getaddress.md) method to validate and parse the network address that the user enters. Use the [CNetAddressCtrl::DisplayErrorTip](../vs140/cnetaddressctrl--displayerrortip.md) method to display an error message infotip if the [CNetAddressCtrl::GetAddress](../vs140/cnetaddressctrl--getaddress.md) method is unsuccessful.  
  
 This message invokes the [NetAddr_SetAllowType](http://msdn.microsoft.com/library/windows/desktop/bb774320) macro, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. That macro sends the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> message.  
  
## See Also  
 [CNetAddressCtrl Class](../vs140/cnetaddressctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [NetAddr_SetAllowType](http://msdn.microsoft.com/library/windows/desktop/bb774320)   
 [NET_STRING](http://msdn.microsoft.com/library/windows/desktop/bb762586)   
 [Error Handling (COM)](http://msdn.microsoft.com/library/windows/desktop/ms679692)   
 [CNetAddressCtrl::GetAddress](../vs140/cnetaddressctrl--getaddress.md)   
 [CNetAddressCtrl::DisplayErrorTip](../vs140/cnetaddressctrl--displayerrortip.md)   
 [CNetAddressCtrl::GetAllowType](../vs140/cnetaddressctrl--getallowtype.md)