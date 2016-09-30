---
title: "CComMultiThreadModelNoCS Class"
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
  - "ATL::CComMultiThreadModelNoCS"
  - "CComMultiThreadModelNoCS"
  - "ATL.CComMultiThreadModelNoCS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ATL, multithreading"
  - "CComMultiThreadModelNoCS class"
  - "threading [ATL]"
ms.assetid: 2b3f7a45-fd72-452c-aaf3-ccdaa621c821
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComMultiThreadModelNoCS Class
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> provides thread-safe methods for incrementing and decrementing the value of a variable, without critical section locking or unlocking functionality.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|[CComMultiThreadModelNoCS::AutoCriticalSection](../vs140/ccommultithreadmodelnocs--autocriticalsection.md)|References class [CComFakeCriticalSection](../vs140/ccomfakecriticalsection-class.md).|  
|[CComMultiThreadModelNoCS::CriticalSection](../vs140/ccommultithreadmodelnocs--criticalsection.md)|References class <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|  
|[CComMultiThreadModelNoCS::ThreadModelNoCS](../vs140/ccommultithreadmodelnocs--threadmodelnocs.md)|References class <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComMultiThreadModelNoCS::Decrement](../vs140/ccommultithreadmodelnocs--decrement.md)|(Static) Decrements the value of the specified variable in a thread-safe manner.|  
|[CComMultiThreadModelNoCS::Increment](../vs140/ccommultithreadmodelnocs--increment.md)|(Static) Increments the value of the specified variable in a thread-safe manner.|  
  
## Remarks  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is similar to [CComMultiThreadModel](../vs140/ccommultithreadmodel-class.md) in that it provides thread-safe methods for incrementing and decrementing a variable. However, when you reference a critical section class through <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, methods such as <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> will do nothing.  
  
 Typically, you use <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> through the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> name. This <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is defined in <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, and [CComSingleThreadModel](../vs140/ccomsinglethreadmodel-class.md).  
  
> [!NOTE]
>  The global <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> names [CComObjectThreadModel](../vs140/ccomobjectthreadmodel.md) and [CComGlobalsThreadModel](../vs140/ccomglobalsthreadmodel.md) do not reference <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 In addition to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> defines <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. These latter two <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> names reference [CComFakeCriticalSection](../vs140/ccomfakecriticalsection-class.md), which provides empty methods associated with obtaining and releasing a critical section.  
  
## Requirements  
 **Header:** atlbase.h  
  
##  \<a name="ccommultithreadmodelnocs__autocriticalsection">\</a>  CComMultiThreadModelNoCS::AutoCriticalSection  
 When using <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> name <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> references class [CComFakeCriticalSection](../vs140/ccomfakecriticalsection-class.md).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 Because <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> does not provide a critical section, its methods do nothing.  
  
 [CComMultiThreadModel](../vs140/ccommultithreadmodel-class.md) and [CComSingleThreadModel](../vs140/ccomsinglethreadmodel-class.md) also contain definitions for <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. The following table shows the relationship between the threading model class and the critical section class referenced by <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>:  
  
|Class defined in|Class referenced|  
|----------------------|----------------------|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|  
  
 In addition to <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, you can use the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> name [CriticalSection](../vs140/ccommultithreadmodelnocs--criticalsection.md). You should not specify <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> in global objects or static class members if you want to eliminate the CRT startup code.  
  
### Example  
 See [CComMultiThreadModel::AutoCriticalSection](../vs140/ccommultithreadmodel--autocriticalsection.md).  
  
##  \<a name="ccommultithreadmodelnocs__criticalsection">\</a>  CComMultiThreadModelNoCS::CriticalSection  
 When using <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> name <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> references class [CComFakeCriticalSection](../vs140/ccomfakecriticalsection-class.md).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 Because <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> does not provide a critical section, its methods do nothing.  
  
 [CComMultiThreadModel](../vs140/ccommultithreadmodel-class.md) and [CComSingleThreadModel](../vs140/ccomsinglethreadmodel-class.md) also contain definitions for <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>. The following table shows the relationship between the threading model class and the critical section class referenced by <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>:  
  
|Class defined in|Class referenced|  
|----------------------|----------------------|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|  
  
 In addition to <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, you can use the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> name <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>. You should not specify <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> in global objects or static class members if you want to eliminate the CRT startup code.  
  
### Example  
 See [CComMultiThreadModel::AutoCriticalSection](../vs140/ccommultithreadmodel--autocriticalsection.md).  
  
##  \<a name="ccommultithreadmodelnocs__decrement">\</a>  CComMultiThreadModelNoCS::Decrement  
 This static function calls the Win32 function [InterlockedDecrement](http://msdn.microsoft.com/library/windows/desktop/ms683580), which decrements the value of the variable pointed to by <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 [in] Pointer to the variable to be decremented.  
  
### Return Value  
 If the result of the decrement is 0, then <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> returns 0. If the result of the decrement is nonzero, the return value is also nonzero but may not equal the result of the decrement.  
  
### Remarks  
 **InterlockedDecrement** prevents more than one thread from simultaneously using this variable.  
  
##  \<a name="ccommultithreadmodelnocs__increment">\</a>  CComMultiThreadModelNoCS::Increment  
 This static function calls the Win32 function [InterlockedIncrement](http://msdn.microsoft.com/library/windows/desktop/ms683614), which increments the value of the variable pointed to by <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 [in] Pointer to the variable to be incremented.  
  
### Return Value  
 If the result of the increment is 0, then **Increment** returns 0. If the result of the increment is nonzero, the return value is also nonzero but may not equal the result of the increment.  
  
### Remarks  
 **InterlockedIncrement** prevents more than one thread from simultaneously using this variable.  
  
##  \<a name="ccommultithreadmodelnocs__threadmodelnocs">\</a>  CComMultiThreadModelNoCS::ThreadModelNoCS  
 When using <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> name <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> simply references <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 [CComMultiThreadModel](../vs140/ccommultithreadmodel-class.md) and [CComSingleThreadModel](../vs140/ccomsinglethreadmodel-class.md) also contain definitions for <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>. The following table shows the relationship between the threading model class and the class referenced by <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>:  
  
|Class defined in|Class referenced|  
|----------------------|----------------------|  
|<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>|  
  
 Note that the definition of <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> provides symmetry with <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>. For example, suppose the sample code in <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> declared the following <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>:  
  
 [!code[NVC_ATL_COM#37](../vs140/codesnippet/CPP/ccommultithreadmodelnocs-class_1.h)]  
  
 Regardless of the class specified for <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> (such as <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>), <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> resolves accordingly.  
  
### Example  
 See [CComMultiThreadModel::AutoCriticalSection](../vs140/ccommultithreadmodel--autocriticalsection.md).  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)