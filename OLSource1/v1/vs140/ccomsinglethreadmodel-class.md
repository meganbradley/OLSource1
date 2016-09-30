---
title: "CComSingleThreadModel Class"
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
  - "ATL.CComSingleThreadModel"
  - "CComSingleThreadModel"
  - "ATL::CComSingleThreadModel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "single-threaded applications"
  - "CComSingleThreadModel class"
  - "single-threaded applications, ATL"
ms.assetid: e5dc30c7-405a-4ba4-8ae9-51937243fce8
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComSingleThreadModel Class
This class provides methods for incrementing and decrementing the value of a variable.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|[CComSingleThreadModel::AutoCriticalSection](../vs140/ccomsinglethreadmodel--autocriticalsection.md)|References class [CComFakeCriticalSection](../vs140/ccomfakecriticalsection-class.md).|  
|[CComSingleThreadModel::CriticalSection](../vs140/ccomsinglethreadmodel--criticalsection.md)|References class <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.|  
|[CComSingleThreadModel::ThreadModelNoCS](../vs140/ccomsinglethreadmodel--threadmodelnocs.md)|References <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComSingleThreadModel::Decrement](../vs140/ccomsinglethreadmodel--decrement.md)|Decrements the value of the specified variable. This implementation is not thread-safe.|  
|[CComSingleThreadModel::Increment](../vs140/ccomsinglethreadmodel--increment.md)|Increments the value of the specified variable. This implementation is not thread-safe.|  
  
## Remarks  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> provides methods for incrementing and decrementing the value of a variable. Unlike [CComMultiThreadModel](../vs140/ccommultithreadmodel-class.md) and [CComMultiThreadModelNoCS](../vs140/ccommultithreadmodelnocs-class.md), these methods are not thread-safe.  
  
 Typically, you use <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> through one of two <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> names, either [CComObjectThreadModel](../vs140/ccomobjectthreadmodel.md) or [CComGlobalsThreadModel](../vs140/ccomglobalsthreadmodel.md). The class referenced by each <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> depends on the threading model used, as shown in the following table:  
  
|typedef|Single threading model|Apartment threading model|Free threading model|  
|-------------|----------------------------|-------------------------------|--------------------------|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|S|S|M|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|S|M|M|  
  
 S= <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>; M= <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> itself defines three <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> names. <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> references <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> reference class [CComFakeCriticalSection](../vs140/ccomfakecriticalsection-class.md), which provides empty methods associated with obtaining and releasing ownership of a critical section.  
  
## Requirements  
 **Header:** atlbase.h  
  
##  \<a name="ccomsinglethreadmodel__autocriticalsection">\</a>  CComSingleThreadModel::AutoCriticalSection  
 When using <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> name <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> references class [CComFakeCriticalSection](../vs140/ccomfakecriticalsection-class.md).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 Because <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> does not provide a critical section, its methods do nothing.  
  
 [CComMultiThreadModel](../vs140/ccommultithreadmodel-class.md) and [CComMultiThreadModelNoCS](../vs140/ccommultithreadmodelnocs-class.md) contain definitions for <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. The following table shows the relationship between the threading model class and the critical section class referenced by <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>:  
  
|Class defined in|Class referenced|  
|----------------------|----------------------|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|  
  
 In addition to <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, you can use the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> name [CriticalSection](../vs140/ccomsinglethreadmodel--criticalsection.md). You should not specify <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> in global objects or static class members if you want to eliminate the CRT startup code.  
  
### Example  
 See [CComMultiThreadModel::AutoCriticalSection](../vs140/ccommultithreadmodel--autocriticalsection.md).  
  
##  \<a name="ccomsinglethreadmodel__criticalsection">\</a>  CComSingleThreadModel::CriticalSection  
 When using <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> name <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> references class [CComFakeCriticalSection](../vs140/ccomfakecriticalsection-class.md).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 Because <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> does not provide a critical section, its methods do nothing.  
  
 [CComMultiThreadModel](../vs140/ccommultithreadmodel-class.md) and [CComMultiThreadModelNoCS](../vs140/ccommultithreadmodelnocs-class.md) contain definitions for <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>. The following table shows the relationship between the threading model class and the critical section class referenced by <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>:  
  
|Class defined in|Class referenced|  
|----------------------|----------------------|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|  
  
 In addition to <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, you can use the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> name [AutoCriticalSection](../vs140/ccomsinglethreadmodel--autocriticalsection.md). You should not specify <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> in global objects or static class members if you want to eliminate the CRT startup code.  
  
### Example  
 See [CComMultiThreadModel::AutoCriticalSection](../vs140/ccommultithreadmodel--autocriticalsection.md).  
  
##  \<a name="ccomsinglethreadmodel__decrement">\</a>  CComSingleThreadModel::Decrement  
 This static function decrements the value of the variable pointed to by <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 [in] Pointer to the variable to be decremented.  
  
### Return Value  
 The result of the decrement.  
  
##  \<a name="ccomsinglethreadmodel__increment">\</a>  CComSingleThreadModel::Increment  
 This static function decrements the value of the variable pointed to by <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 [in] Pointer to the variable to be incremented.  
  
### Return Value  
 The result of the increment.  
  
##  \<a name="ccomsinglethreadmodel__threadmodelnocs">\</a>  CComSingleThreadModel::ThreadModelNoCS  
 When using <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> name <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> simply references <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 [CComMultiThreadModel](../vs140/ccommultithreadmodel-class.md) and [CComMultiThreadModelNoCS](../vs140/ccommultithreadmodelnocs-class.md) contain definitions for <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>. The following table shows the relationship between the threading model class and the class referenced by <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>:  
  
|Class defined in|Class referenced|  
|----------------------|----------------------|  
|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>|  
  
### Example  
 See [CComMultiThreadModel::AutoCriticalSection](../vs140/ccommultithreadmodel--autocriticalsection.md).  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)