---
title: "CRegKey::NotifyChangeKeyValue"
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
  - "ATL::CRegKey::NotifyChangeKeyValue"
  - "ATL.CRegKey.NotifyChangeKeyValue"
  - "NotifyChangeKeyValue"
  - "CRegKey.NotifyChangeKeyValue"
  - "CRegKey::NotifyChangeKeyValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "REG_NOTIFY_CHANGE_ATTRIBUTES"
  - "REG_NOTIFY_CHANGE_NAME"
  - "REG_NOTIFY_CHANGE_SECURITY"
  - "REG_NOTIFY_CHANGE_LAST_SET"
  - "NotifyChangeKeyValue method"
ms.assetid: 5822dc01-9681-4b74-92ff-93ba93e99761
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRegKey::NotifyChangeKeyValue
This method notifies the caller about changes to the attributes or contents of the open registry key.  
  
## Syntax  
  
```  
  
      LONG NotifyChangeKeyValue(  
   BOOL bWatchSubtree,  
   DWORD dwNotifyFilter,  
   HANDLE hEvent,  
   BOOL bAsync = TRUE   
) throw( );  
```  
  
#### Parameters  
 *bWatchSubtree*  
 Specifies a flag that indicates whether to report changes in the specified key and all of its subkeys or only in the specified key. If this parameter is TRUE, the method reports changes in the key and its subkeys. If the parameter is FALSE, the method reports changes only in the key.  
  
 *dwNotifyFilter*  
 Specifies a set of flags that control which changes should be reported. This parameter can be a combination of the following values:  
  
|Value|Meaning|  
|-----------|-------------|  
|REG_NOTIFY_CHANGE_NAME|Notify the caller if a subkey is added or deleted.|  
|REG_NOTIFY_CHANGE_ATTRIBUTES|Notify the caller of changes to the attributes of the key, such as the security descriptor information.|  
|REG_NOTIFY_CHANGE_LAST_SET|Notify the caller of changes to a value of the key. This can include adding or deleting a value, or changing an existing value.|  
|REG_NOTIFY_CHANGE_SECURITY|Notify the caller of changes to the security descriptor of the key.|  
  
 `hEvent`  
 Handle to an event. If the *bAsync* parameter is TRUE, the method returns immediately and changes are reported by signaling this event. If `bAsync` is FALSE, `hEvent` is ignored.  
  
 `bAsync`  
 Specifies a flag that indicates how the method reports changes. If this parameter is TRUE, the method returns immediately and reports changes by signaling the specified event. When this parameter is FALSE, the method does not return until a change has occurred. If `hEvent` does not specify a valid event, the `bAsync` parameter cannot be TRUE.  
  
## Return Value  
 If the method succeeds, the return value is ERROR_SUCCESS. If the method fails, the return value is a nonzero error code defined in WINERROR.H.  
  
## Remarks  
  
> [!NOTE]
>  This method does not notify the caller if the specified key is deleted.  
  
 For more details and a sample program, see [RegNotifyChangeKeyValue](http://msdn.microsoft.com/library/windows/desktop/ms724892).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CRegKey Class](../vs140/cregkey-class.md)