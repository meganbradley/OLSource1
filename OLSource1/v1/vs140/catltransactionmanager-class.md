---
title: "CAtlTransactionManager Class"
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
  - "CAtlTransactionManager"
  - "atltransactionmanager/ATL::CAtlTransactionManager"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAtlTransactionManager class"
ms.assetid: b01732dc-1d16-4b42-bfac-b137fca2b740
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlTransactionManager Class
CAtlTransactionManager class provides a wrapper to Kernel Transaction Manager (KTM) functions.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlTransactionManager::~CAtlTransactionManager](../vs140/catltransactionmanager--~catltransactionmanager.md)|CAtlTransactionManager destructor.|  
|[CAtlTransactionManager::CAtlTransactionManager](../vs140/catltransactionmanager--catltransactionmanager.md)|CAtlTransactionManager constructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlTransactionManager::Close](../vs140/catltransactionmanager--close.md)|Closes one the transaction handle.|  
|[CAtlTransactionManager::Commit](../vs140/catltransactionmanager--commit.md)|Requests that the transaction be committed.|  
|[CAtlTransactionManager::Create](../vs140/catltransactionmanager--create.md)|Creates the transaction handle.|  
|[CAtlTransactionManager::CreateFile](../vs140/catltransactionmanager--createfile.md)|Creates or opens a file, file stream, or directory as a transacted operation.|  
|[CAtlTransactionManager::DeleteFile](../vs140/catltransactionmanager--deletefile.md)|Deletes an existing file as a transacted operation.|  
|[CAtlTransactionManager::FindFirstFile](../vs140/catltransactionmanager--findfirstfile.md)|Searches a directory for a file or subdirectory as a transacted operation.|  
|[CAtlTransactionManager::GetFileAttributes](../vs140/catltransactionmanager--getfileattributes.md)|Retrieves file system attributes for a specified file or directory as a transacted operation.|  
|[CAtlTransactionManager::GetFileAttributesEx](../vs140/catltransactionmanager--getfileattributesex.md)|Retrieves file system attributes for a specified file or directory as a transacted operation.|  
|[CAtlTransactionManager::GetHandle](../vs140/catltransactionmanager--gethandle.md)|Returns the transaction handle.|  
|[CAtlTransactionManager::IsFallback](../vs140/catltransactionmanager--isfallback.md)|Determines whether the fallback calls are enabled.|  
|[CAtlTransactionManager::MoveFile](../vs140/catltransactionmanager--movefile.md)|Moves an existing file or a directory, including its children, as a transacted operation.|  
|[CAtlTransactionManager::RegCreateKeyEx](../vs140/catltransactionmanager--regcreatekeyex.md)|Creates the specified registry key and associates it with a transaction. If the key already exists, the function opens it.|  
|[CAtlTransactionManager::RegDeleteKey](../vs140/catltransactionmanager--regdeletekey.md)|Deletes a subkey and its values from the specified platform-specific view of the registry as a transacted operation.|  
|[CAtlTransactionManager::RegOpenKeyEx](../vs140/catltransactionmanager--regopenkeyex.md)|Opens the specified registry key and associates it with a transaction.|  
|[CAtlTransactionManager::Rollback](../vs140/catltransactionmanager--rollback.md)|Requests that the transaction be rolled back.|  
|[CAtlTransactionManager::SetFileAttributes](../vs140/catltransactionmanager--setfileattributes.md)|Sets the attributes for a file or directory as a transacted operation.|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlTransactionManager::m_bFallback](../vs140/catltransactionmanager--m_bfallback.md)|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder> if the fallback is supported; <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> otherwise.|  
|[CAtlTransactionManager::m_hTransaction](../vs140/catltransactionmanager--m_htransaction.md)|The transaction handle.|  
  
## Remarks  
  
## Inheritance Hierarchy  
 [ATL::CAtlTransactionManager](../vs140/catltransactionmanager-class.md)  
  
## Requirements  
 **Header:** atltransactionmanager.h  
  
##  \<a name="catltransactionmanager___dtorcatltransactionmanager">\</a>  CAtlTransactionManager::~CAtlTransactionManager  
 CAtlTransactionManager destructor.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 In normal processing, the transaction is automatically committed and closed. If the destructor is called during an exception unwind, the transaction is rolled back and closed.  
  
##  \<a name="catltransactionmanager__catltransactionmanager">\</a>  CAtlTransactionManager::CAtlTransactionManager  
 CAtlTransactionManager constructor.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> indicates support fallback. If transacted function fails, the class automatically calls the "non-transacted" function. <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> indicates no "fallback" calls.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> indicates that the transaction handler is created automatically in the constructor. <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> indicates that it is not.  
  
### Remarks  
  
##  \<a name="catltransactionmanager__close">\</a>  CAtlTransactionManager::Close  
 Closes the transaction handle.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> if successful; otherwise <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
### Remarks  
 This wrapper calls the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> function. The method is automatically called in the destructor.  
  
##  \<a name="catltransactionmanager__commit">\</a>  CAtlTransactionManager::Commit  
 Requests that the transaction be committed.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> if successful; otherwise <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
### Remarks  
 This wrapper calls the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> function. The method is automatically called in the destructor.  
  
##  \<a name="catltransactionmanager__create">\</a>  CAtlTransactionManager::Create  
 Creates the transaction handle.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> if successful; otherwise <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
### Remarks  
 This wrapper calls the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> function. Check it for  
  
##  \<a name="catltransactionmanager__createfile">\</a>  CAtlTransactionManager::CreateFile  
 Creates or opens a file, file stream, or directory as a transacted operation.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 The name of an object to be created or opened.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 The access to the object, which can be summarized as read, write, both, or neither (zero). The most commonly used values are GENERIC_READ, GENERIC_WRITE, or both: GENERIC_READ &#124; GENERIC_WRITE.  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 The sharing mode of an object, which can be read, write, both, delete, all of these, or none: 0, FILE_SHARE_DELETE, FILE_SHARE_READ, FILE_SHARE_WRITE.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 A pointer to a SECURITY_ATTRIBUTES structure that contains an optional security descriptor and also determines whether or not the returned handle can be inherited by child processes. The parameter can be <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 An action to take on files that exist and do not exist. This parameter must be one of the following values, which cannot be combined: CREATE_ALWAYS, CREATE_NEW, OPEN_ALWAYS, OPEN_EXISTING, or TRUNCATE_EXISTING.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 The file attributes and flags. This parameter can include any combination of the available file attributes (FILE_ATTRIBUTE_*). All other file attributes override FILE_ATTRIBUTE_NORMAL. This parameter can also contain combinations of flags (FILE_FLAG_\*) for control of buffering behavior, access modes, and other special-purpose flags. These combine with any FILE_ATTRIBUTE_\* values.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 A valid handle to a template file with the GENERIC_READ access right. The template file supplies file attributes and extended attributes for the file that is being created. This parameter can be <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>.  
  
### Return Value  
 Returns a handle that can be used to access the object.  
  
### Remarks  
 This wrapper calls the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> function.  
  
##  \<a name="catltransactionmanager__deletefile">\</a>  CAtlTransactionManager::DeleteFile  
 Deletes an existing file as a transacted operation.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 The name of the file to be deleted.  
  
### Remarks  
 This wrapper calls the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> function.  
  
##  \<a name="catltransactionmanager__findfirstfile">\</a>  CAtlTransactionManager::FindFirstFile  
 Searches a directory for a file or subdirectory as a transacted operation.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 The directory or path, and the file name to search for. This parameter can include wildcard characters, such as an asterisk (*) or a question mark (?).  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 A pointer to the WIN32_FIND_DATA structure that receives information about a found file or subdirectory.  
  
### Return Value  
 If the function succeeds, the return value is a search handle used in a subsequent call to <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>. If the function fails or fails to locate files from the search string in the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> parameter, the return value is INVALID_HANDLE_VALUE.  
  
### Remarks  
 This wrapper calls the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> function.  
  
##  \<a name="catltransactionmanager__getfileattributes">\</a>  CAtlTransactionManager::GetFileAttributes  
 Retrieves file system attributes for a specified file or directory as a transacted operation.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 The name of the file or directory.  
  
### Remarks  
 This wrapper calls the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> function.  
  
##  \<a name="catltransactionmanager__getfileattributesex">\</a>  CAtlTransactionManager::GetFileAttributesEx  
 Retrieves file system attributes for a specified file or directory as a transacted operation.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 The name of the file or directory.  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 The level of attribute information to retrieve.  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 A pointer to a buffer that receives the attribute information. The type of attribute information that is stored into this buffer is determined by the value of <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>. If the <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> parameter is GetFileExInfoStandard then this parameter points to a WIN32_FILE_ATTRIBUTE_DATA structure.  
  
### Remarks  
 This wrapper calls the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> function.  
  
##  \<a name="catltransactionmanager__gethandle">\</a>  CAtlTransactionManager::GetHandle  
 Returns the transaction handle.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 Returns the transaction handle for a class. Returns <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> if the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> is not attached to a handle.  
  
### Remarks  
  
##  \<a name="catltransactionmanager__isfallback">\</a>  CAtlTransactionManager::IsFallback  
 Determines whether the fallback calls are enabled.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> is the class supports fallback calls. <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
  
##  \<a name="catltransactionmanager__m_bfallback">\</a>  CAtlTransactionManager::m_bFallback  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> if the fallback is supported; <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> otherwise.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="catltransactionmanager__m_htransaction">\</a>  CAtlTransactionManager::m_hTransaction  
 The transaction handle.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="catltransactionmanager__movefile">\</a>  CAtlTransactionManager::MoveFile  
 Moves an existing file or a directory, including its children, as a transacted operation.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 The current name of the existing file or directory on the local computer.  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 The new name for the file or directory. This name must not already exist. A new file may be on a different file system or drive. A new directory must be on the same drive.  
  
### Remarks  
 This wrapper calls the <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> function.  
  
##  \<a name="catltransactionmanager__regcreatekeyex">\</a>  CAtlTransactionManager::RegCreateKeyEx  
 Creates the specified registry key and associates it with a transaction. If the key already exists, the function opens it.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 A handle to an open registry key.  
  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 The name of a subkey that this function opens or creates.  
  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 This parameter is reserved and must be zero.  
  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 The user-defined class of this key. This parameter may be ignored. This parameter can be NULL.  
  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 This parameter can be one of the following values: REG_OPTION_BACKUP_RESTORE, REG_OPTION_NON_VOLATILE, or REG_OPTION_VOLATILE.  
  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 A mask that specifies the access rights for the key.  
  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 Pointer to a SECURITY_ATTRIBUTES structure that determines whether the returned handle can be inherited by child processes. If <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>, the handle cannot be inherited.  
  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 A pointer to a variable that receives a handle to the opened or created key. If the key is not one of the predefined registry keys, call the <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> function after you have finished using the handle.  
  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 A pointer to a variable that receives one of the following disposition values: REG_CREATED_NEW_KEY or REG_OPENED_EXISTING_KEY.  
  
### Return Value  
 If the function succeeds, the return value is ERROR_SUCCESS. If the function fails, the return value is a nonzero error code defined in Winerror.h.  
  
### Remarks  
 This wrapper calls the <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> function.  
  
##  \<a name="catltransactionmanager__regdeletekey">\</a>  CAtlTransactionManager::RegDeleteKey  
 Deletes a subkey and its values from the specified platform-specific view of the registry as a transacted operation.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>86\</CodeContentPlaceHolder>|A handle to an open registry key.|  
|<CodeContentPlaceHolder>87\</CodeContentPlaceHolder>|The name of the key to be deleted.|  
  
### Return Value  
 If the function succeeds, the return value is ERROR_SUCCESS. If the function fails, the return value is a nonzero error code defined in Winerror.h.  
  
### Remarks  
 This wrapper calls the <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> function.  
  
##  \<a name="catltransactionmanager__regopenkeyex">\</a>  CAtlTransactionManager::RegOpenKeyEx  
 Opens the specified registry key and associates it with a transaction.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 A handle to an open registry key.  
  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 The name of the registry subkey to be opened.  
  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 This parameter is reserved and must be zero.  
  
 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 A mask that specifies the access rights for the key.  
  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 A pointer to a variable that receives a handle to the opened or created key. If the key is not one of the predefined registry keys, call the <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> function after you have finished using the handle.  
  
### Return Value  
 If the function succeeds, the return value is ERROR_SUCCESS. If the function fails, the return value is a nonzero error code defined in Winerror.h  
  
### Remarks  
 This wrapper calls the <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> function.  
  
##  \<a name="catltransactionmanager__rollback">\</a>  CAtlTransactionManager::Rollback  
 Requests that the transaction be rolled back.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> if successful; otherwise <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>.  
  
### Remarks  
 This wrapper calls the <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> function.  
  
##  \<a name="catltransactionmanager__setfileattributes">\</a>  CAtlTransactionManager::SetFileAttributes  
 Sets the attributes for a file or directory as a transacted operation.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
 The name of the file or directory.  
  
 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 The file attributes to set for the file. For more information, see [SetFileAttributesTransacted](http://go.microsoft.com/fwlink/?LinkId=158699).  
  
### Remarks  
 This wrapper calls the <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> function.  
  
## See Also  
 [ATL](../vs140/atl-com-desktop-components.md)