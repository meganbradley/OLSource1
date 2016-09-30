---
title: "CSettingsStore Class"
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
  - "CSettingsStore"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSettingsStore class"
ms.assetid: 0ea181de-a13e-4b29-b560-7c43838223ff
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSettingsStore Class
Wraps Windows API functions, providing an object-oriented interface that you use to access the registry.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CSettingsStore::CSettingsStore](#csettingsstore__csettingsstore)|Constructs a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CSettingsStore::Close](#csettingsstore__close)|Closes the open registry key.|  
|[CSettingsStore::CreateKey](#csettingsstore__createkey)|Opens the specified key or creates it if it does not exist.|  
|[CSettingsStore::DeleteKey](#csettingsstore__deletekey)|Deletes the specified key and all its children.|  
|[CSettingsStore::DeleteValue](#csettingsstore__deletevalue)|Deletes the specified value of the open key.|  
|[CSettingsStore::Open](#csettingsstore__open)|Opens the specified key.|  
|[CSettingsStore::Read](#csettingsstore__read)|Retrieves the data for a specified key value.|  
|[CSettingsStore::Write](#csettingsstore__write)|Writes a value to the registry under the open key.|  
  
## Remarks  
 The member functions <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> are very similar. If the registry key already exists, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function in the same way. However, if the registry key does not exist, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> will create it whereas <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> will return an error value.  
  
## Example  
 The following example demonstrates how to use the Open and Read methods of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> class. This code snippet is part of the [Tool Tip Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_ToolTipDemo#1](../vs140/codesnippet/CPP/csettingsstore-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CSettingsStore](../vs140/csettingsstore-class.md)  
  
## Requirements  
 **Header:** afxsettingsstore.h  
  
##  \<a name="csettingsstore__close">\</a>  CSettingsStore::Close  
 Closes the open registry key.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 By default, this method is called from the destructor of the [CSettingsStore Class](../vs140/csettingsstore-class.md).  
  
##  \<a name="csettingsstore__createkey">\</a>  CSettingsStore::CreateKey  
 Opens a registry key or creates it if it does not exist.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Specifies the name of a key to be created or opened.  
  
### Return Value  
 0 if successful; otherwise a nonzero value.  
  
### Remarks  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> uses <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> as the root of registry inquiries. It searches for <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> as a subkey of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. If the key does not exist, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> creates it. Otherwise, it opens the key. <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> then sets <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> to the created or opened key.  
  
##  \<a name="csettingsstore__csettingsstore">\</a>  CSettingsStore::CSettingsStore  
 Creates a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 Boolean parameter that specifies whether the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object is acting in administrator mode.  
  
 [in] <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 Boolean parameter that specifies whether the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object is created in read-only mode.  
  
### Remarks  
 If <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> member variable is set to <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>. If you set <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
 The security access depends on the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> parameter. If <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, the security access will be set to <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, the security access will be set to a combination of <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. For more information about security access together with the registry, see                         [Registry Key Security and Access Rights](http://msdn.microsoft.com/library/windows/desktop/ms724878).  
  
 The destructor for <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> releases <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> automatically.  
  
##  \<a name="csettingsstore__deletekey">\</a>  CSettingsStore::DeleteKey  
 Deletes a key and all its children from the registry.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 The name of the key to delete.  
  
 [in] <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 Switch that specifies the location of the key to delete.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 This method will fail if the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> object is in read-only mode.  
  
 If the parameter <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> is zero, <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> searches for the key to delete under <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> is nonzero, <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> searches for the key to delete under <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>.  
  
##  \<a name="csettingsstore__deletevalue">\</a>  CSettingsStore::DeleteValue  
 Deletes a value from <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 Specifies the value field to remove.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
##  \<a name="csettingsstore__open">\</a>  CSettingsStore::Open  
 Opens a registry key.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 The name of a registry key.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 After this method successfully opens the specified key, it sets <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> to the handle of this key.  
  
##  \<a name="csettingsstore__read">\</a>  CSettingsStore::Read  
 Reads a value from a key in the registry.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string that contains the name of the value to read from the registry.  
  
 [out] <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 Reference to an integer variable that receives the value read from the registry key.  
  
 [out] <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 Reference to a 32-bit double word variable that receives the value read from the registry key.  
  
 [out] <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 Reference to a string variable that receives the value read from the registry key.  
  
 [out] <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 Reference to a string list variable that receives the value read from the registry key.  
  
 [out] <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 Reference to a string array variable that receives the value read from the registry key.  
  
 [out] <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 Reference to a 32-bit double word array variable that receives the value read from the registry key.  
  
 [out] <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 Reference to a 16-bit word array variable that receives the value read from the registry key.  
  
 [out] <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 Reference to a byte array variable that receives the value read from the registry key.  
  
 [out] <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 Reference to a pointer to a <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> structure that receives the value read from the registry key.  
  
 [out] <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 Reference to a [CRect](../vs140/crect-class.md) variable that receives the value read from the registry key.  
  
 [out] <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 Pointer to a pointer to data that receives the value read from the registry key.  
  
 [out] <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 Pointer to an unsigned integer variable. This variable receives the size of the buffer that <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> points to.  
  
 [out] <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 Reference to a [CObList](../vs140/coblist-class.md) variable that receives the value read from the registry key.  
  
 [out] <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 Reference to a [CObject](../vs140/cobject-class.md) variable that receives the value read from the registry key.  
  
 [out] <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 Reference to a pointer to a <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> variable that receives the value read from the registry key.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> checks for <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> as a subkey of <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>.  
  
##  \<a name="csettingsstore__write">\</a>  CSettingsStore::Write  
 Writes a value to the registry under the open key.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 Pointer to a string that contains the name of the value to set.  
  
 [in] <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 Reference to an integer variable that contains the data to store.  
  
 [in] <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 Reference to a 32-bit double word variable that contains the data to store.  
  
 [in] <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string variable that contains the data to store.  
  
 [in] <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 Reference to a [CStringList](../vs140/cstringlist-class.md) variable that contains the data to store.  
  
 [in] <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 Reference to a byte array variable that contains the data to store.  
  
 [in] <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 Reference to a string array variable that contains the data to store.  
  
 [in] <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 Reference to a 32-bit double word array variable that contains the data to store.  
  
 [in] <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 Reference to a 16-bit word array variable that contains the data to store.  
  
 [in] <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 Reference to a [CRect](../vs140/crect-class.md) variable that contains the data to store.  
  
 [in] <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 Reference to a pointer to a <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> variable that contains the data to store.  
  
 [in] <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 Pointer to a buffer that contains the data to store.  
  
 [in] <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 Specifies the size, in bytes, of the data to which the <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> parameter points.  
  
 [in] <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
 Reference to a [CObList](../vs140/coblist-class.md) variable that contains the data to store.  
  
 [in] <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
 Reference to a [CObject](../vs140/cobject-class.md) variable that contains the data to store.  
  
 [in] <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 Pointer to a pointer to a <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> variable that contains the data to store.  
  
### Return Value  
 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> if successful; otherwise <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>.  
  
### Remarks  
 In order to write to the registry, you must set <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> to a nonzero value when you create a [CSettingsStore](../vs140/csettingsstore-class.md) object. For more information, see [CSettingsStore::CSettingsStore](#csettingsstore__csettingsstore).  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CWinAppEx Class](../vs140/cwinappex-class.md)