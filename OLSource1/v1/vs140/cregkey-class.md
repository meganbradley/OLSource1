---
title: "CRegKey Class"
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
  - "CRegKey"
  - "ATL::CRegKey"
  - "ATL.CRegKey"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRegKey class"
  - "ATL, registry"
  - "registry, deleting values"
  - "registry, writing to"
  - "registry, deleting keys"
ms.assetid: 3afce82b-ba2c-4c1a-8404-dc969e1af74b
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRegKey Class
This class provides methods for manipulating entries in the system registry.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CRegKey::CRegKey](../vs140/cregkey--cregkey.md)|The constructor.|  
|[CRegKey::~CRegKey](../vs140/cregkey--~cregkey.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CRegKey::Attach](../vs140/cregkey--attach.md)|Call this method to attach an HKEY to the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object by setting the [m_hKey](../vs140/cregkey--m_hkey.md) member handle to <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.|  
|[CRegKey::Close](../vs140/cregkey--close.md)|Call this method to release the [m_hKey](../vs140/cregkey--m_hkey.md) member handle and set it to NULL.|  
|[CRegKey::Create](../vs140/cregkey--create.md)|Call this method to create the specified key, if it does not exist as a subkey of <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.|  
|[CRegKey::DeleteSubKey](../vs140/cregkey--deletesubkey.md)|Call this method to remove the specified key from the registry.|  
|[CRegKey::DeleteValue](../vs140/cregkey--deletevalue.md)|Call this method to remove a value field from [m_hKey](../vs140/cregkey--m_hkey.md).|  
|[CRegKey::Detach](../vs140/cregkey--detach.md)|Call this method to detach the [m_hKey](../vs140/cregkey--m_hkey.md) member handle from the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object and set <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> to NULL.|  
|[CRegKey::EnumKey](../vs140/cregkey--enumkey.md)|Call this method to enumerate the subkeys of the open registry key.|  
|[CRegKey::Flush](../vs140/cregkey--flush.md)|Call this method to write all of the attributes of the open registry key into the registry.|  
|[CRegKey::GetKeySecurity](../vs140/cregkey--getkeysecurity.md)|Call this method to retrieve a copy of the security descriptor protecting the open registry key.|  
|[CRegKey::NotifyChangeKeyValue](../vs140/cregkey--notifychangekeyvalue.md)|This method notifies the caller about changes to the attributes or contents of the open registry key.|  
|[CRegKey::Open](../vs140/cregkey--open.md)|Call this method to open the specified key and set [m_hKey](../vs140/cregkey--m_hkey.md) to the handle of this key.|  
|[CRegKey::QueryBinaryValue](../vs140/cregkey--querybinaryvalue.md)|Call this method to retrieve the binary data for a specified value name.|  
|[CRegKey::QueryDWORDValue](../vs140/cregkey--querydwordvalue.md)|Call this method to retrieve the DWORD data for a specified value name.|  
|[CRegKey::QueryGUIDValue](../vs140/cregkey--queryguidvalue.md)|Call this method to retrieve the GUID data for a specified value name.|  
|[CRegKey::QueryMultiStringValue](../vs140/cregkey--querymultistringvalue.md)|Call this method to retrieve the multistring data for a specified value name.|  
|[CRegKey::QueryQWORDValue](../vs140/cregkey--queryqwordvalue.md)|Call this method to retrieve the QWORD data for a specified value name.|  
|[CRegKey::QueryStringValue](../vs140/cregkey--querystringvalue.md)|Call this method to retrieve the string data for a specified value name.|  
|[CRegKey::QueryValue](../vs140/cregkey--queryvalue.md)|Call this method to retrieve the data for the specified value field of [m_hKey](../vs140/cregkey--m_hkey.md). Earlier versions of this method are no longer supported and are marked as **ATL_DEPRECATED**.|  
|[CRegKey::RecurseDeleteKey](../vs140/cregkey--recursedeletekey.md)|Call this method to remove the specified key from the registry and explicitly remove any subkeys.|  
|[CRegKey::SetBinaryValue](../vs140/cregkey--setbinaryvalue.md)|Call this method to set the binary value of the registry key.|  
|[CRegKey::SetDWORDValue](../vs140/cregkey--setdwordvalue.md)|Call this method to set the DWORD value of the registry key.|  
|[CRegKey::SetGUIDValue](../vs140/cregkey--setguidvalue.md)|Call this method to set the GUID value of the registry key.|  
|[CRegKey::SetKeySecurity](../vs140/cregkey--setkeysecurity.md)|Call this method to set the security of the registry key.|  
|[CRegKey::SetKeyValue](../vs140/cregkey--setkeyvalue.md)|Call this method to store data in a specified value field of a specified key.|  
|[CRegKey::SetMultiStringValue](../vs140/cregkey--setmultistringvalue.md)|Call this method to set the multistring value of the registry key.|  
|[CRegKey::SetQWORDValue](../vs140/cregkey--setqwordvalue.md)|Call this method to set the QWORD value of the registry key.|  
|[CRegKey::SetStringValue](../vs140/cregkey--setstringvalue.md)|Call this method to set the string value of the registry key.|  
|[CRegKey::SetValue](../vs140/cregkey--setvalue.md)|Call this method to store data in the specified value field of [m_hKey](../vs140/cregkey--m_hkey.md). Earlier versions of this method are no longer supported and are marked as **ATL_DEPRECATED**.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CRegKey::operator HKEY](../vs140/cregkey--operator-hkey.md)|Converts a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object to an HKEY.|  
|[CRegKey::operator =](../vs140/cregkey--operator-=.md)|Assignment operator.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CRegKey::m_hKey](../vs140/cregkey--m_hkey.md)|Contains a handle of the registry key associated with the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object.|  
|[CRegKey::m_pTM](../vs140/cregkey--m_ptm.md)|Pointer to <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object|  
  
## Remarks  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> provides methods for creating and deleting keys and values in the system registry. The registry contains an installation-specific set of definitions for system components, such as software version numbers, logical-to-physical mappings of installed hardware, and COM objects.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> provides a programming interface to the system registry for a given machine. For example, to open a particular registry key, call <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. To retrieve or modify a data value, call <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, respectively. To close a key, call <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.  
  
 When you close a key, its registry data is written (flushed) to the hard disk. This process may take several seconds. If your application must explicitly write registry data to the hard disk, you can call the [RegFlushKey](http://msdn.microsoft.com/library/windows/desktop/ms724867) Win32 function. However,                 **RegFlushKey** uses many system resources and should be called only when absolutely necessary.  
  
> [!IMPORTANT]
>  Any methods that allow the caller to specify a registry location have the potential to read data that cannot be trusted. Methods that make use of [RegQueryValueEx](http://msdn.microsoft.com/library/windows/desktop/ms724911) should take into consideration that this function does not explicitly handle strings which are NULL terminated. Both conditions should be checked for by the calling code.  
  
## Requirements  
 **Header:** atlbase.h  
  
##  \<a name="cregkey__attach">\</a>  CRegKey::Attach  
 Call this method to attach an HKEY to the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object by setting the [m_hKey](../vs140/cregkey--m_hkey.md) member handle to <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 The handle of a registry key.  
  
### Remarks  
 **Attach** will assert if <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> is non-NULL.  
  
##  \<a name="cregkey__close">\</a>  CRegKey::Close  
 Call this method to release the [m_hKey](../vs140/cregkey--m_hkey.md) member handle and set it to NULL.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 If successful, returns ERROR_SUCCESS; otherwise returns an error value.  
  
##  \<a name="cregkey__create">\</a>  CRegKey::Create  
 Call this method to create the specified key, if it does not exist as a subkey of <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 The handle of an open key.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 Specifies the name of a key to be created or opened. This name must be a subkey of <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 Specifies the class of the key to be created or opened. The default value is REG_NONE.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 Options for the key. The default value is REG_OPTION_NON_VOLATILE. For a list of possible values and descriptions, see [RegCreateKeyEx](http://msdn.microsoft.com/library/windows/desktop/ms724844) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 The security access for the key. The default value is KEY_READ &#124; KEY_WRITE. For a list of possible values and descriptions, see **RegCreateKeyEx**.  
  
 *lpSecAttr*  
 A pointer to a [SECURITY_ATTRIBUTES](http://msdn.microsoft.com/library/windows/desktop/aa379560) structure that indicates whether the handle of the key can be inherited by a child process. By default, this parameter is NULL (meaning the handle cannot be inherited).  
  
 *lpdwDisposition*  
 [out] If non-NULL, retrieves either REG_CREATED_NEW_KEY (if the key did not exist and was created) or REG_OPENED_EXISTING_KEY (if the key existed and was opened).  
  
### Return Value  
 If successful, returns ERROR_SUCCESS and opens the key. If the method fails, the return value is a nonzero error code defined in WINERROR.H.  
  
### Remarks  
 **Create** sets the [m_hKey](../vs140/cregkey--m_hkey.md) member to the handle of this key.  
  
##  \<a name="cregkey__cregkey">\</a>  CRegKey::CRegKey  
 The constructor.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 A handle to a registry key.  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 Pointer to CAtlTransactionManager object  
  
### Remarks  
 Creates a new <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> object. The object can be created from an existing <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> object, or from a handle to a registry key.  
  
##  \<a name="cregkey___dtorcregkey">\</a>  CRegKey::~CRegKey  
 The destructor.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 The destructor releases <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>.  
  
##  \<a name="cregkey__deletesubkey">\</a>  CRegKey::DeleteSubKey  
 Call this method to remove the specified key from the registry.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 Specifies the name of the key to delete. This name must be a subkey of [m_hKey](../vs140/cregkey--m_hkey.md).  
  
### Return Value  
 If successful, returns ERROR_SUCCESS. If the method fails, the return value is a nonzero error code defined in WINERROR.H.  
  
### Remarks  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> can only delete a key that has no subkeys. If the key has subkeys, call [RecurseDeleteKey](../vs140/cregkey--recursedeletekey.md) instead.  
  
##  \<a name="cregkey__deletevalue">\</a>  CRegKey::DeleteValue  
 Call this method to remove a value field from [m_hKey](../vs140/cregkey--m_hkey.md).  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 Specifies the value field to remove.  
  
### Return Value  
 If successful, returns ERROR_SUCCESS. If the method fails, the return value is a nonzero error code defined in WINERROR.H.  
  
##  \<a name="cregkey__detach">\</a>  CRegKey::Detach  
 Call this method to detach the [m_hKey](../vs140/cregkey--m_hkey.md) member handle from the <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> object and set <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> to NULL.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 The HKEY associated with the <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> object.  
  
##  \<a name="cregkey__enumkey">\</a>  CRegKey::EnumKey  
 Call this method to enumerate the subkeys of the open registry key.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 The subkey index. This parameter should be zero for the first call and then incremented for subsequent calls  
  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 Pointer to a buffer that receives the name of the subkey, including the terminating null character. Only the name of the subkey is copied to the buffer, not the full key hierarchy.  
  
 *pnNameLength*  
 Pointer to a variable that specifies the size, in TCHARs, of the buffer specified by the <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> parameter. This size should include the terminating null character. When the method returns, the variable pointed to by *pnNameLength* contains the number of characters stored in the buffer. The count returned does not include the terminating null character.  
  
 *pftLastWriteTime*  
 Pointer to a variable that receives the time the enumerated subkey was last written to.  
  
### Return Value  
 If the method succeeds, the return value is ERROR_SUCCESS. If the method fails, the return value is a nonzero error code defined in WINERROR.H.  
  
### Remarks  
 To enumerate the subkeys, call <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> with an index of zero. Increment the index value and repeat until the method returns ERROR_NO_MORE_ITEMS. For more information, see [RegEnumKeyEx](http://msdn.microsoft.com/library/windows/desktop/ms724862) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cregkey__flush">\</a>  CRegKey::Flush  
 Call this method to write all of the attributes of the open registry key into the registry.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 If the method succeeds, the return value is ERROR_SUCCESS. If the method fails, the return value is a nonzero error code defined in WINERROR.H.  
  
### Remarks  
 For more information, see [RegEnumFlush](http://msdn.microsoft.com/library/windows/desktop/ms724867) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cregkey__getkeysecurity">\</a>  CRegKey::GetKeySecurity  
 Call this method to retrieve a copy of the security descriptor protecting the open registry key.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 The [SECURITY_INFORMATION](http://msdn.microsoft.com/library/windows/desktop/aa379573) value that indicates the requested security information.  
  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 A pointer to a buffer that receives a copy of the requested security descriptor.  
  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 The size, in bytes, of the buffer pointed to by <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>.  
  
### Return Value  
 If the method succeeds, the return value is ERROR_SUCCESS. If the method fails, the return value is a nonzero error code is defined in WINERROR.H.  
  
### Remarks  
 For more information, see [RegGetKeySecurity](http://msdn.microsoft.com/library/windows/desktop/aa379313).  
  
##  \<a name="cregkey__m_hkey">\</a>  CRegKey::m_hKey  
 Contains a handle of the registry key associated with the <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
##  \<a name="cregkey__m_ptm">\</a>  CRegKey::m_pTM  
 Pointer to a <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cregkey__notifychangekeyvalue">\</a>  CRegKey::NotifyChangeKeyValue  
 This method notifies the caller about changes to the attributes or contents of the open registry key.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
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
  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 Handle to an event. If the *bAsync* parameter is TRUE, the method returns immediately and changes are reported by signaling this event. If <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> is FALSE, <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> is ignored.  
  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 Specifies a flag that indicates how the method reports changes. If this parameter is TRUE, the method returns immediately and reports changes by signaling the specified event. When this parameter is FALSE, the method does not return until a change has occurred. If <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> does not specify a valid event, the <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> parameter cannot be TRUE.  
  
### Return Value  
 If the method succeeds, the return value is ERROR_SUCCESS. If the method fails, the return value is a nonzero error code defined in WINERROR.H.  
  
### Remarks  
  
> [!NOTE]
>  This method does not notify the caller if the specified key is deleted.  
  
 For more details and a sample program, see [RegNotifyChangeKeyValue](http://msdn.microsoft.com/library/windows/desktop/ms724892).  
  
##  \<a name="cregkey__open">\</a>  CRegKey::Open  
 Call this method to open the specified key and set [m_hKey](../vs140/cregkey--m_hkey.md) to the handle of this key.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 The handle of an open key.  
  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 Specifies the name of a key to be created or opened. This name must be a subkey of <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 The security access for the key. The default value is KEY_ALL_ACCESS. For a list of possible values and descriptions, see [RegCreateKeyEx](http://msdn.microsoft.com/library/windows/desktop/ms724844) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Return Value  
 If successful, returns ERROR_SUCCESS; otherwise, a non-zero error value defined in WINERROR.H.  
  
### Remarks  
 If the <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> parameter is NULL or points to an empty string,                         **Open** opens a new handle of the key identified by <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>, but does not close any previously opened handle.  
  
 Unlike [CRegKey::Create](../vs140/cregkey--create.md),                         **Open** will not create the specified key if it does not exist.  
  
##  \<a name="cregkey__operator_hkey">\</a>  CRegKey::operator HKEY  
 Converts a <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> object to an HKEY.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
##  \<a name="cregkey__operator__eq">\</a>  CRegKey::operator =  
 Assignment operator.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 The key to copy.  
  
### Return Value  
 Returns a reference to the new key.  
  
### Remarks  
 This operator detaches <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> from its current object and assigns it to the <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> object instead.  
  
##  \<a name="cregkey__querybinaryvalue">\</a>  CRegKey::QueryBinaryValue  
 Call this method to retrieve the binary data for a specified value name.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string containing the name of the value to query.  
  
 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 Pointer to a buffer that receives the value's data.  
  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 Pointer to a variable that specifies the size, in bytes, of the buffer pointed to by the <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> parameter. When the method returns, this variable contains the size of the data copied to the buffer.  
  
### Return Value  
 If the method succeeds, ERROR_SUCCESS is returned. If the method fails to read a value, it returns a nonzero error code defined in WINERROR.H. If the data referenced is not of type REG_BINARY, ERROR_INVALID_DATA is returned.  
  
### Remarks  
 This method makes use of **RegQueryValueEx** and confirms that the correct type of data is returned. See [RegQueryValueEx](http://msdn.microsoft.com/library/windows/desktop/ms724911) for more details.  
  
> [!IMPORTANT]
>  This method allows the caller to specify any registry location, potentially reading data which cannot be trusted. Also, the [RegQueryValueEx](http://msdn.microsoft.com/library/windows/desktop/ms724911) function used by this method does not explicitly handle strings which are NULL terminated. Both conditions should be checked for by the calling code.  
  
##  \<a name="cregkey__querydwordvalue">\</a>  CRegKey::QueryDWORDValue  
 Call this method to retrieve the DWORD data for a specified value name.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string containing the name of the value to query.  
  
 <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
 Pointer to a buffer that receives the DWORD.  
  
### Return Value  
 If the method succeeds, ERROR_SUCCESS is returned. If the method fails to read a value, it returns a nonzero error code defined in WINERROR.H. If the data referenced is not of type REG_DWORD, ERROR_INVALID_DATA is returned.  
  
### Remarks  
 This method makes use of **RegQueryValueEx** and confirms that the correct type of data is returned. See [RegQueryValueEx](http://msdn.microsoft.com/library/windows/desktop/ms724911) for more details.  
  
> [!IMPORTANT]
>  This method allows the caller to specify any registry location, potentially reading data which cannot be trusted. Also, the [RegQueryValueEx](http://msdn.microsoft.com/library/windows/desktop/ms724911) function used by this method does not explicitly handle strings which are NULL terminated. Both conditions should be checked for by the calling code.  
  
##  \<a name="cregkey__queryguidvalue">\</a>  CRegKey::QueryGUIDValue  
 Call this method to retrieve the GUID data for a specified value name.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string containing the name of the value to query.  
  
 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
 Pointer to a variable that receives the GUID.  
  
### Return Value  
 If the method succeeds, ERROR_SUCCESS is returned. If the method fails to read a value, it returns a nonzero error code defined in WINERROR.H. If the data referenced is not a valid GUID, ERROR_INVALID_DATA is returned.  
  
### Remarks  
 This method makes use of <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> and converts the string into a GUID using [CLSIDFromString](http://msdn.microsoft.com/library/windows/desktop/ms680589).  
  
> [!IMPORTANT]
>  This method allows the caller to specify any registry location, potentially reading data which cannot be trusted.  
  
##  \<a name="cregkey__querymultistringvalue">\</a>  CRegKey::QueryMultiStringValue  
 Call this method to retrieve the multistring data for a specified value name.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string containing the name of the value to query.  
  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 Pointer to a buffer that receives the multistring data. A multistring is an array of null-terminated strings, terminated by two null characters.  
  
 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 The size, in TCHARs, of the buffer pointed to by <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>. When the method returns, <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> contains the size, in TCHARs, of the multistring retrieved, including a terminating null character.  
  
### Return Value  
 If the method succeeds, ERROR_SUCCESS is returned. If the method fails to read a value, it returns a nonzero error code defined in WINERROR.H. If the data referenced is not of type REG_MULTI_SZ, ERROR_INVALID_DATA is returned.  
  
### Remarks  
 This method makes use of **RegQueryValueEx** and confirms that the correct type of data is returned. See [RegQueryValueEx](http://msdn.microsoft.com/library/windows/desktop/ms724911) for more details.  
  
> [!IMPORTANT]
>  This method allows the caller to specify any registry location, potentially reading data which cannot be trusted. Also, the [RegQueryValueEx](http://msdn.microsoft.com/library/windows/desktop/ms724911) function used by this method does not explicitly handle strings which are NULL terminated. Both conditions should be checked for by the calling code.  
  
##  \<a name="cregkey__queryqwordvalue">\</a>  CRegKey::QueryQWORDValue  
 Call this method to retrieve the QWORD data for a specified value name.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string containing the name of the value to query.  
  
 <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
 Pointer to a buffer that receives the QWORD.  
  
### Return Value  
 If the method succeeds, ERROR_SUCCESS is returned. If the method fails to read a value, it returns a nonzero error code defined in WINERROR.H. If the data referenced is not of type REG_QWORD, ERROR_INVALID_DATA is returned.  
  
### Remarks  
 This method makes use of **RegQueryValueEx** and confirms that the correct type of data is returned. See [RegQueryValueEx](http://msdn.microsoft.com/library/windows/desktop/ms724911) for more details.  
  
> [!IMPORTANT]
>  This method allows the caller to specify any registry location, potentially reading data which cannot be trusted. Also, the [RegQueryValueEx](http://msdn.microsoft.com/library/windows/desktop/ms724911) function used by this method does not explicitly handle strings which are NULL terminated. Both conditions should be checked for by the calling code.  
  
##  \<a name="cregkey__querystringvalue">\</a>  CRegKey::QueryStringValue  
 Call this method to retrieve the string data for a specified value name.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string containing the name of the value to query.  
  
 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
 Pointer to a buffer that receives the string data.  
  
 <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
 The size, in TCHARs, of the buffer pointed to by <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>. When the method returns, <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> contains the size, in TCHARs, of the string retrieved, including a terminating null character.  
  
### Return Value  
 If the method succeeds, ERROR_SUCCESS is returned. If the method fails to read a value, it returns a nonzero error code defined in WINERROR.H. If the data referenced is not of type REG_SZ, ERROR_INVALID_DATA is returned. If the method returns ERROR_MORE_DATA, <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> equals zero, not the required buffer size in bytes.  
  
### Remarks  
 This method makes use of **RegQueryValueEx** and confirms that the correct type of data is returned. See [RegQueryValueEx](http://msdn.microsoft.com/library/windows/desktop/ms724911) for more details.  
  
> [!IMPORTANT]
>  This method allows the caller to specify any registry location, potentially reading data which cannot be trusted. Also, the [RegQueryValueEx](http://msdn.microsoft.com/library/windows/desktop/ms724911) function used by this method does not explicitly handle strings which are NULL terminated. Both conditions should be checked for by the calling code.  
  
##  \<a name="cregkey__queryvalue">\</a>  CRegKey::QueryValue  
 Call this method to retrieve the data for the specified value field of [m_hKey](../vs140/cregkey--m_hkey.md). Earlier versions of this method are no longer supported and are marked as **ATL_DEPRECATED**.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string containing the name of the value to query. If <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> is NULL or an empty string, "", the method retrieves the type and data for the key's unnamed or default value, if any.  
  
 <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
 Pointer to a variable that receives a code indicating the type of data stored in the specified value. The <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> parameter can be NULL if the type code is not required.  
  
 <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
 Pointer to a buffer that receives the value's data. This parameter can be NULL if the data is not required.  
  
 <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
 Pointer to a variable that specifies the size, in bytes, of the buffer pointed to by the <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> parameter. When the method returns, this variable contains the size of the data copied to *pData.*  
  
 <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
 The value field's numerical data.  
  
 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
 Specifies the value field to be queried.  
  
 <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
 The value field's string data.  
  
 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
 The size of the string data. Its value is initially set to the size of the <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> buffer.  
  
### Return Value  
 If successful, returns ERROR_SUCCESS; otherwise, a nonzero error code defined in WINERROR.H.  
  
### Remarks  
 The two original versions of <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> are no longer supported and are marked as **ATL_DEPRECATED**. The compiler will issue a warning if these forms are used.  
  
 The remaining method calls RegQueryValueEx.  
  
> [!IMPORTANT]
>  This method allows the caller to specify any registry location, potentially reading data which cannot be trusted. Also, the RegQueryValueEx function used by this method does not explicitly handle strings which are <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> terminated. Both conditions should be checked for by the calling code.  
  
##  \<a name="cregkey__recursedeletekey">\</a>  CRegKey::RecurseDeleteKey  
 Call this method to remove the specified key from the registry and explicitly remove any subkeys.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 *lpszKey*  
 Specifies the name of the key to delete. This name must be a subkey of [m_hKey](../vs140/cregkey--m_hkey.md).  
  
### Return Value  
 If successful, returns ERROR_SUCCESS; otherwise, a non-zero error value defined in WINERROR.H.  
  
### Remarks  
 If the key has subkeys, you must call this method to delete the key.  
  
##  \<a name="cregkey__setbinaryvalue">\</a>  CRegKey::SetBinaryValue  
 Call this method to set the binary value of the registry key.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
 Pointer to a string containing the name of the value to set. If a value with this name is not already present, the method adds it to the key.  
  
 <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>  
 Pointer to a buffer containing the data to be stored with the specified value name.  
  
 <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
 Specifies the size, in bytes, of the information pointed to by the <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> parameter.  
  
### Return Value  
 If the method succeeds, the return value is ERROR_SUCCESS. If the method fails, the return value is a nonzero error code defined in WINERROR.H.  
  
### Remarks  
 This method uses [RegSetValueEx](http://msdn.microsoft.com/library/windows/desktop/ms724923) to write the value to the registry.  
  
##  \<a name="cregkey__setdwordvalue">\</a>  CRegKey::SetDWORDValue  
 Call this method to set the DWORD value of the registry key.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
 Pointer to a string containing the name of the value to set. If a value with this name is not already present, the method adds it to the key.  
  
 <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
 The DWORD data to be stored with the specified value name.  
  
### Return Value  
 If the method succeeds, the return value is ERROR_SUCCESS. If the method fails, the return value is a nonzero error code defined in WINERROR.H.  
  
### Remarks  
 This method uses [RegSetValueEx](http://msdn.microsoft.com/library/windows/desktop/ms724923) to write the value to the registry.  
  
##  \<a name="cregkey__setguidvalue">\</a>  CRegKey::SetGUIDValue  
 Call this method to set the GUID value of the registry key.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
 Pointer to a string containing the name of the value to set. If a value with this name is not already present, the method adds it to the key.  
  
 <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>  
 Reference to the GUID to be stored with the specified value name.  
  
### Return Value  
 If the method succeeds, the return value is ERROR_SUCCESS. If the method fails, the return value is a nonzero error code defined in WINERROR.H.  
  
### Remarks  
 This method makes use of <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> and converts the GUID into a string using [StringFromGUID2](http://msdn.microsoft.com/library/windows/desktop/ms683893).  
  
##  \<a name="cregkey__setkeyvalue">\</a>  CRegKey::SetKeyValue  
 Call this method to store data in a specified value field of a specified key.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>  
 Specifies the name of the key to be created or opened. This name must be a subkey of [m_hKey](../vs140/cregkey--m_hkey.md).  
  
 <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>  
 Specifies the data to be stored. This parameter must be non-NULL.  
  
 <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
 Specifies the value field to be set. If a value field with this name does not already exist in the key, it is added.  
  
### Return Value  
 If successful, returns ERROR_SUCCESS; otherwise, a nonzero error code defined in WINERROR.H.  
  
### Remarks  
 Call this method to create or open the <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> key and store the <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> data in the <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> value field.  
  
##  \<a name="cregkey__setkeysecurity">\</a>  CRegKey::SetKeySecurity  
 Call this method to set the security of the registry key.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>  
 Specifies the components of the security descriptor to set. The value can be a combination of the following values:  
  
|Value|Meaning|  
|-----------|-------------|  
|DACL_SECURITY_INFORMATION|Sets the key's discretionary access-control list (DACL). The key must have WRITE_DAC access, or the calling process must be the object's owner.|  
|GROUP_SECURITY_INFORMATION|Sets the key's primary group security identifier (SID). The key must have WRITE_OWNER access, or the calling process must be the object's owner.|  
|OWNER_SECURITY_INFORMATION|Sets the key's owner SID. The key must have WRITE_OWNER access, or the calling process must be the object's owner or have the SE_TAKE_OWNERSHIP_NAME privilege enabled.|  
|SACL_SECURITY_INFORMATION|Sets the key's system access-control list (SACL). The key must have ACCESS_SYSTEM_SECURITY access. The proper way to get this access is to enable the SE_SECURITY_NAME [privilege](http://msdn.microsoft.com/library/windows/desktop/aa379306) in the caller's current access token, open the handle for ACCESS_SYSTEM_SECURITY access, and then disable the privilege.|  
  
 <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>  
 Pointer to a [SECURITY_DESCRIPTOR](http://msdn.microsoft.com/library/windows/desktop/aa379561) structure that specifies the security attributes to set for the specified key.  
  
### Return Value  
 If the method succeeds, the return value is ERROR_SUCCESS. If the method fails, the return value is a nonzero error code defined in WINERROR.H.  
  
### Remarks  
 Sets the key's security attributes. See [RegSetKeySecurity](http://msdn.microsoft.com/library/windows/desktop/aa379314) for more details.  
  
##  \<a name="cregkey__setmultistringvalue">\</a>  CRegKey::SetMultiStringValue  
 Call this method to set the multistring value of the registry key.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>  
 Pointer to a string containing the name of the value to set. If a value with this name is not already present, the method adds it to the key.  
  
 <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>  
 Pointer to the multistring data to be stored with the specified value name. A multistring is an array of null-terminated strings, terminated by two null characters.  
  
### Return Value  
 If the method succeeds, the return value is ERROR_SUCCESS. If the method fails, the return value is a nonzero error code defined in WINERROR.H.  
  
### Remarks  
 This method uses [RegSetValueEx](http://msdn.microsoft.com/library/windows/desktop/ms724923) to write the value to the registry.  
  
##  \<a name="cregkey__setqwordvalue">\</a>  CRegKey::SetQWORDValue  
 Call this method to set the QWORD value of the registry key.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>  
 Pointer to a string containing the name of the value to set. If a value with this name is not already present, the method adds it to the key.  
  
 <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>  
 The QWORD data to be stored with the specified value name.  
  
### Return Value  
 If the method succeeds, the return value is ERROR_SUCCESS. If the method fails, the return value is a nonzero error code defined in WINERROR.H.  
  
### Remarks  
 This method uses [RegSetValueEx](http://msdn.microsoft.com/library/windows/desktop/ms724923) to write the value to the registry.  
  
##  \<a name="cregkey__setstringvalue">\</a>  CRegKey::SetStringValue  
 Call this method to set the string value of the registry key.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>  
 Pointer to a string containing the name of the value to set. If a value with this name is not already present, the method adds it to the key.  
  
 <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>  
 Pointer to the string data to be stored with the specified value name.  
  
 <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>  
 The type of the string to write to the registry: either REG_SZ (the default) or REG_EXPAND_SZ (for multistrings).  
  
### Return Value  
 If the method succeeds, the return value is ERROR_SUCCESS. If the method fails, the return value is a nonzero error code defined in WINERROR.H.  
  
### Remarks  
 This method uses [RegSetValueEx](http://msdn.microsoft.com/library/windows/desktop/ms724923\(v=vs.85\).aspx) to write the value to the registry.  
  
##  \<a name="cregkey__setvalue">\</a>  CRegKey::SetValue  
 Call this method to store data in the specified value field of [m_hKey](../vs140/cregkey--m_hkey.md). Earlier versions of this method are no longer supported and are marked as **ATL_DEPRECATED**.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>  
 Pointer to a string containing the name of the value to set. If a value with this name is not already present in the key, the method adds it to the key. If <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> is NULL or an empty string, "", the method sets the type and data for the key's unnamed or default value.  
  
 <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>  
 Specifies a code indicating the type of data pointed to by the <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>  
 Pointer to a buffer containing the data to be stored with the specified value name.  
  
 <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>  
 Specifies the size, in bytes, of the information pointed to by the <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> parameter. If the data is of type REG_SZ, REG_EXPAND_SZ, or REG_MULTI_SZ, <CodeContentPlaceHolder>166\</CodeContentPlaceHolder> must include the size of the terminating null character.  
  
 <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>  
 The handle of an open key.  
  
 <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>  
 Specifies the name of a key to be created or opened. This name must be a subkey of <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>  
 Specifies the data to be stored. This parameter must be non-NULL.  
  
 <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>  
 Specifies the value field to be set. If a value field with this name does not already exist in the key, it is added.  
  
 <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>  
 Specifies the data to be stored.  
  
 <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>  
 If false, indicates the string is of type REG_SZ. If true, indicates the string is a multistring of type REG_MULTI_SZ.  
  
 <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> is true, <CodeContentPlaceHolder>176\</CodeContentPlaceHolder> is the length of the *lpszValue* string in characters. If <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> is false, a value of -1 indicates that the method will calculate the length automatically.  
  
### Return Value  
 If successful, returns ERROR_SUCCESS; otherwise, a nonzero error code defined in WINERROR.H.  
  
### Remarks  
 The two original versions of <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> are marked as **ATL_DEPRECATED** and should no longer be used. The compiler will issue a warning if these forms are used.  
  
 The third method calls [RegSetValueEx](http://msdn.microsoft.com/library/windows/desktop/ms724923).  
  
## See Also  
 [DCOM Sample](../vs140/visual-c---samples.md)   
 [Class Overview](../vs140/atl-class-overview.md)   
 [Registry Overview](http://msdn.microsoft.com/library/windows/desktop/ms724871)   
 [Registry Functions](http://msdn.microsoft.com/library/windows/desktop/ms724875)   
 [Registry Value Types](http://msdn.microsoft.com/library/windows/desktop/ms724884)