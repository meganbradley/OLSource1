---
title: "CFileTime Class"
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
  - "ATL::CFileTime"
  - "CFileTime"
  - "ATL.CFileTime"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFileTime class"
  - "shared classes, CFileTime"
ms.assetid: 1a358a65-1383-4124-b0d4-59b026e6860f
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileTime Class
This class provides methods for managing the date and time values associated with a file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CFileTime::CFileTime](#cfiletime__cfiletime)|The constructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CFileTime::GetCurrentTime](#cfiletime__getcurrenttime)|Call this static function to retrieve a                                         <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object that represents the current system date and time.|  
|[CFileTime::GetTime](#cfiletime__gettime)|Call this method to retrieve the time from the                                         <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object.|  
|[CFileTime::LocalToUTC](#cfiletime__localtoutc)|Call this method to convert a local file time to a file time based on the Coordinated Universal Time (UTC).|  
|[CFileTime::SetTime](#cfiletime__settime)|Call this method to set the date and time stored by the                                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object.|  
|[CFileTime::UTCToLocal](#cfiletime__utctolocal)|Call this method to convert time based on the Coordinated Universal Time (UTC) to local file time.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CFileTime::operator -](#cfiletime__operator_-)|This operator is used to perform subtraction on a                                         <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> or                                         <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object.|  
|[CFileTime::operator !=](#cfiletime__operator__neq)|This operator compares two                                         <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> objects for inequality.|  
|[CFileTime::operator +](#cfiletime__operator__add)|This operator is used to perform addition on a                                         <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object.|  
|[CFileTime::operator +=](#cfiletime__operator__add_eq)|This operator is used to perform addition on a                                         <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object and assign the result to the current object.|  
|[CFileTime::operator <](#cfiletime__operator__lt_)|This operator compares two                                         <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> objects to determine the lesser.|  
|[CFileTime::operator <=](#cfiletime__operator__lt__eq)|This operator compares two                                         <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> objects to determine equality or the lesser.|  
|[CFileTime::operator =](#cfiletime__operator__eq)|The assignment operator.|  
|[CFileTime::operator -=](#cfiletime__operator_-_eq)|This operator is used to perform subtraction on a                                         <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object and assign the result to the current object.|  
|[CFileTime::operator ==](#cfiletime__operator__eq_eq)|This operator compares two                                         <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> objects for equality.|  
|[CFileTime::operator >](#cfiletime__operator__gt_)|This operator compares two                                         <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> objects to determine the larger.|  
|[CFileTime::operator >=](#cfiletime__operator__gt__eq)|This operator compares two                                         <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> objects to determine equality or the larger.|  
  
### Public Constants  
  
|Name|Description|  
|----------|-----------------|  
|[CFileTime::Day](#cfiletime__day)|A static data member storing the number of 100-nanosecond intervals that make up one day.|  
|[CFileTime::Hour](#cfiletime__hour)|A static data member storing the number of 100-nanosecond intervals that make up one hour.|  
|[CFileTime::Millisecond](#cfiletime__millisecond)|A static data member storing the number of 100-nanosecond intervals that make up one millisecond.|  
|[CFileTime::Minute](#cfiletime__minute)|A static data member storing the number of 100-nanosecond intervals that make up one minute.|  
|[CFileTime::Second](#cfiletime__second)|A static data member storing the number of 100-nanosecond intervals that make up one second.|  
|[CFileTime::Week](#cfiletime__week)|A static data member storing the number of 100-nanosecond intervals that make up one week.|  
  
## Remarks  
 This class provides methods for managing the date and time values associated with the creation, access and modification of files. The methods and data of this class are frequently used in conjunction with                 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> objects, which deal with relative time values.  
  
 The date and time value is stored as a 64-bit value representing the number of 100-nanosecond intervals since January 1, 1601. This is the Coordinated Universal Time (UTC) format.  
  
 The following static const member variables are provided to simplify calculations:  
  
|Member variable|Number of 100-nanosecond intervals|  
|---------------------|-----------------------------------------|  
|Millisecond|10,000|  
|Second|Millisecond * 1,000|  
|Minute|Second * 60|  
|Hour|Minute * 60|  
|Day|Hour * 24|  
|Week|Day * 7|  
  
 **Note** Not all file systems can record creation and last access time and not all file systems record them in the same manner. For example, on the Windows NT FAT file system, create time has a resolution of 10 milliseconds, write time has a resolution of 2 seconds, and access time has a resolution of 1 day (the access date). On NTFS, access time has a resolution of 1 hour. Furthermore, FAT records times on disk in local time, but NTFS records times on disk in UTC. For more information, see                 [File Times](http://msdn.microsoft.com/library/windows/desktop/ms724290).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atltime.h  
  
##  \<a name="cfiletime__cfiletime">\</a>  CFileTime::CFileTime  
 The constructor.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 A                                 [FILETIME](http://msdn.microsoft.com/library/windows/desktop/ms724284) structure.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 The date and time expressed as a 64-bit value.  
  
### Remarks  
 The                         <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object can be created using an existing date and time from a                         <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> structure, or expressed as a 64-bit value (in local or Coordinated Universal Time (UTC) time formats). The default constructor sets the time to 0.  
  
##  \<a name="cfiletime__day">\</a>  CFileTime::Day  
 A static data member storing the number of 100-nanosecond intervals that make up one day.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Example  
 See the example for                                 [CFileTime::Millisecond](#cfiletime__millisecond).  
  
##  \<a name="cfiletime__getcurrenttime">\</a>  CFileTime::GetCurrentTime  
 Call this static function to retrieve a                 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object that represents the current system date and time.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 Returns the current system date and time in Coordinated Universal Time (UTC) format.  
  
### Example  
 [!code[NVC_MFCFiles#41](../vs140/codesnippet/CPP/cfiletime-class_1.cpp)]  
  
##  \<a name="cfiletime__gettime">\</a>  CFileTime::GetTime  
 Call this method to retrieve the time from the                 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 Returns the date and time as a 64-bit number, which may be in either local or Coordinated Universal Time (UTC) format.  
  
##  \<a name="cfiletime__hour">\</a>  CFileTime::Hour  
 A static data member storing the number of 100-nanosecond intervals that make up one hour.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Example  
 See the example for                                 [CFileTime::Millisecond](#cfiletime__millisecond).  
  
##  \<a name="cfiletime__localtoutc">\</a>  CFileTime::LocalToUTC  
 Call this method to convert a local file time to a file time based on the Coordinated Universal Time (UTC).  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 Returns a                         <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object containing the time in UTC format.  
  
### Example  
 See the example for                                 [CFileTime::UTCToLocal](#cfiletime__utctolocal).  
  
##  \<a name="cfiletime__millisecond">\</a>  CFileTime::Millisecond  
 A static data member storing the number of 100-nanosecond intervals that make up one millisecond.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Example  
 [!code[NVC_MFCFiles#44](../vs140/codesnippet/CPP/cfiletime-class_2.cpp)]  
  
##  \<a name="cfiletime__minute">\</a>  CFileTime::Minute  
 A static data member storing the number of 100-nanosecond intervals that make up one minute.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Example  
 See the example for                                 [CFileTime::Millisecond](#cfiletime__millisecond).  
  
##  \<a name="cfiletime__operator_-">\</a>  CFileTime::operator -  
 This operator is used to perform subtraction on a                 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> or                 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 A                                 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 A                                 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Returns a                         <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object or a                         <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object representing the result of the time difference between the two objects.  
  
##  \<a name="cfiletime__operator__neq">\</a>  CFileTime::operator !=  
 This operator compares two                 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> objects for inequality.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> object to be compared.  
  
### Return Value  
 Returns                         **true** if the item being compared is not equal to the                         <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> object, otherwise                         **false**.  
  
##  \<a name="cfiletime__operator__add">\</a>  CFileTime::operator +  
 This operator is used to perform addition on a                 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 A                                 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Returns a                         <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> object representing the result of the original time plus a relative time.  
  
##  \<a name="cfiletime__operator__add_eq">\</a>  CFileTime::operator +=  
 This operator is used to perform addition on a                 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> object and assign the result to the current object.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 A                                 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Returns the updated                         <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> object, representing the result of the original time plus a relative time.  
  
##  \<a name="cfiletime__operator__lt_">\</a>  CFileTime::operator &lt;  
 This operator compares two                 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> objects to determine the lesser.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> object to be compared.  
  
### Return Value  
 Returns                         **true** if the first object is less (earlier in time) than the second,                         **false** otherwise.  
  
### Example  
 [!code[NVC_MFCFiles#43](../vs140/codesnippet/CPP/cfiletime-class_3.cpp)]  
  
##  \<a name="cfiletime__operator__lt__eq">\</a>  CFileTime::operator &lt;=  
 This operator compares two                 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> objects to determine equality or the lesser.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> object to be compared.  
  
### Return Value  
 Returns                         **true** if the first object is less than (earlier in time) or equal to the second, otherwise                         **false**.  
  
##  \<a name="cfiletime__operator__eq">\</a>  CFileTime::operator =  
 The assignment operator.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 A                                 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> object containing the new time and date.  
  
### Return Value  
 Returns the updated                         <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> object.  
  
##  \<a name="cfiletime__operator_-_eq">\</a>  CFileTime::operator -=  
 This operator is used to perform subtraction on a                 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> object and assign the result to the current object.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 A                                 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> object containing the relative time to subtract.  
  
### Return Value  
 Returns the updated                         <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> object.  
  
##  \<a name="cfiletime__operator__eq_eq">\</a>  CFileTime::operator ==  
 This operator compares two                 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> objects for equality.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> object to compare.  
  
### Return Value  
 Returns                         **true** if the objects are equal, otherwise                         **false**.  
  
##  \<a name="cfiletime__operator__gt_">\</a>  CFileTime::operator &gt;  
 This operator compares two                 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> objects to determine the larger.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> object to be compared.  
  
### Return Value  
 Returns                         **true** if the first object is greater than (later in time) than the second, otherwise                         **false**.  
  
##  \<a name="cfiletime__operator__gt__eq">\</a>  CFileTime::operator &gt;=  
 This operator compares two                 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> objects to determine equality or the larger.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> object to be compared.  
  
### Return Value  
 Returns                         **true** if the first object is greater than (later in time) or equal to the second, otherwise                         **false**.  
  
##  \<a name="cfiletime__second">\</a>  CFileTime::Second  
 A static data member storing the number of 100-nanosecond intervals that make up one day.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Example  
 See the example for                                 [CFileTime::Millisecond](#cfiletime__millisecond).  
  
##  \<a name="cfiletime__settime">\</a>  CFileTime::SetTime  
 Call this method to set the date and time stored by the                 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 The 64-bit value representing the date and time, in either local or Coordinated Universal Time (UTC) format.  
  
##  \<a name="cfiletime__utctolocal">\</a>  CFileTime::UTCToLocal  
 Call this method to convert time based on the Coordinated Universal Time (UTC) to local file time.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
 Returns a                         <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> object containing the time in local file time format.  
  
### Example  
 [!code[NVC_MFCFiles#42](../vs140/codesnippet/CPP/cfiletime-class_4.cpp)]  
  
##  \<a name="cfiletime__week">\</a>  CFileTime::Week  
 A static data member storing the number of 100-nanosecond intervals that make up one week.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Example  
 See the example for                                 [CFileTime::Millisecond](#cfiletime__millisecond).  
  
## See Also  
 [FILETIME](http://msdn.microsoft.com/library/windows/desktop/ms724284)   
 [CFileTimeSpan Class](../vs140/cfiletimespan-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Shared Classes](../vs140/atl-mfc-shared-classes.md)