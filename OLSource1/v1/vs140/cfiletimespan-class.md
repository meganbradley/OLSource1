---
title: "CFileTimeSpan Class"
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
  - "CFileTimeSpan"
  - "ATL.CFileTimeSpan"
  - "ATL::CFileTimeSpan"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "shared classes, CFileTimeSpan"
  - "CFileTimeSpan class"
ms.assetid: 5856fb39-9c82-4027-8ccf-8760890491ec
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileTimeSpan Class
This class provides methods for managing relative date and time values associated with a file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CFileTimeSpan::CFileTimeSpan](#cfiletimespan__cfiletimespan)|The constructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CFileTimeSpan::GetTimeSpan](#cfiletimespan__gettimespan)|Call this method to retrieve the time span from the                                         <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.|  
|[CFileTimeSpan::SetTimeSpan](#cfiletimespan__settimespan)|Call this method to set the time span of the                                         <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CFileTimeSpan::operator -](#cfiletimespan__operator_-)|Performs subtraction on a                                         <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.|  
|[CFileTimeSpan::operator !=](#cfiletimespan__operator__neq)|Compares two                                         <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> objects for inequality.|  
|[CFileTimeSpan::operator +](#cfiletimespan__operator__add)|Performs addition on a                                         <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object.|  
|[CFileTimeSpan::operator +=](#cfiletimespan__operator__add_eq)|Performs addition on a                                         <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object and assign the result to the current object.|  
|[CFileTimeSpan::operator <](#cfiletimespan__operator__lt_)|Compares two                                         <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> objects to determine the lesser.|  
|[CFileTimeSpan::operator <=](#cfiletimespan__operator__lt__eq)|Compares two                                         <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> objects to determine equality or the lesser.|  
|[CFileTimeSpan::operator =](#cfiletimespan__operator__eq)|The assignment operator.|  
|[CFileTimeSpan::operator -=](#cfiletimespan__operator_-_eq)|Performs subtraction on a                                         <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object and assign the result to the current object.|  
|[CFileTimeSpan::operator ==](#cfiletimespan__operator__eq_eq)|Compares two                                         <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> objects for equality.|  
|[CFileTimeSpan::operator >](#cfiletimespan__operator__gt_)|Compares two                                         <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> objects to determine the larger.|  
|[CFileTimeSpan::operator >=](#cfiletimespan__operator__gt__eq)|Compares two                                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> objects to determine equality or the larger.|  
  
## Remarks  
 This class provides methods for managing relative periods of time often encountered when performing operations concerning when a file was created, last accessed or last modified. The methods of this class are frequently used in conjunction with                 [CFileTime class](../vs140/cfiletime-class.md) objects.  
  
## Example  
 See the example for                     [CFileTime::Millisecond](../vs140/cfiletime-class.md#cfiletime__millisecond).  
  
## Requirements  
 **Header:** atltime.h  
  
##  \<a name="cfiletimespan__cfiletimespan">\</a>  CFileTimeSpan::CFileTimeSpan  
 The constructor.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 An existing                                 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 A period of time in milliseconds.  
  
### Remarks  
 The                         <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object can be created using an existing                         <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object, or expressed as a 64-bit value. The default constructor sets the time span to 0.  
  
##  \<a name="cfiletimespan__gettimespan">\</a>  CFileTimeSpan::GetTimeSpan  
 Call this method to retrieve the time span from the                 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 Returns the time span in milliseconds.  
  
##  \<a name="cfiletimespan__operator_-">\</a>  CFileTimeSpan::operator -  
 Performs subtraction on a                 **CFileTimeSpan** object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 A                                 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Returns a                         <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object representing the result of the difference between two time spans.  
  
##  \<a name="cfiletimespan__operator__neq">\</a>  CFileTimeSpan::operator !=  
 Compares two                 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> objects for inequality.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object to be compared.  
  
### Return Value  
 Returns                         **true** if the item being compared is not equal to the                         <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object; otherwise                         **false**.  
  
##  \<a name="cfiletimespan__operator__add">\</a>  CFileTimeSpan::operator +  
 Performs addition on a                 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 A                                 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Returns a                         <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object containing the sum of the two time spans.  
  
##  \<a name="cfiletimespan__operator__add_eq">\</a>  CFileTimeSpan::operator +=  
 Performs addition on a                 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object and assigns the result to the current object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 A                                 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Returns the updated                         <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object containing the sum of the two time spans.  
  
##  \<a name="cfiletimespan__operator__lt_">\</a>  CFileTimeSpan::operator &lt;  
 Compares two                 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> objects to determine the lesser.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> object to be compared.  
  
### Return Value  
 Returns                         **true** if the first object is less (that is, represents a shorter time period) than the second, otherwise                         **false**.  
  
##  \<a name="cfiletimespan__operator__lt__eq">\</a>  CFileTimeSpan::operator &lt;=  
 Compares two                 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> objects to determine equality or the lesser.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> object to be compared.  
  
### Return Value  
 Returns                         **true** if the first object is less than (that is, represents a shorter time period) or equal to the second, otherwise                         **false**.  
  
##  \<a name="cfiletimespan__operator__eq">\</a>  CFileTimeSpan::operator =  
 The assignment operator.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 A                                 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Returns the updated                         <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> object.  
  
##  \<a name="cfiletimespan__operator_-_eq">\</a>  CFileTimeSpan::operator -=  
 Performs subtraction on a                 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> object and assigns the result to the current object.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 A                                 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Returns the updated                         <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> object.  
  
##  \<a name="cfiletimespan__operator__eq_eq">\</a>  CFileTimeSpan::operator ==  
 Compares two                 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> objects for equality.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> object to be compared.  
  
### Return Value  
 Returns                         **true** if the objects are equal, otherwise                         **false**.  
  
##  \<a name="cfiletimespan__operator__gt_">\</a>  CFileTimeSpan::operator &gt;  
 Compares two                 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> objects to determine the larger.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> object to be compared.  
  
### Return Value  
 Returns                         **true** if the first object is greater than (that is, represents a longer time period) than the second, otherwise                         **false**.  
  
##  \<a name="cfiletimespan__operator__gt__eq">\</a>  CFileTimeSpan::operator &gt;=  
 Compares two                 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> objects to determine equality or the larger.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> object to be compared.  
  
### Return Value  
 Returns                         **true** if the first object is greater than (that is, represents a longer time period) or equal to the second, otherwise                         **false**.  
  
##  \<a name="cfiletimespan__settimespan">\</a>  CFileTimeSpan::SetTimeSpan  
 Call this method to set the time span of the                 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 The new value for the time span in milliseconds.  
  
## See Also  
 [FILETIME](http://msdn.microsoft.com/library/windows/desktop/ms724284)   
 [CFileTime Class](../vs140/cfiletime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Shared Classes](../vs140/atl-mfc-shared-classes.md)