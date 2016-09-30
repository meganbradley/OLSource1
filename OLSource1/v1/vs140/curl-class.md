---
title: "CUrl Class"
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
  - "ATL.CUrl"
  - "CUrl"
  - "ATL::CUrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CUrl class"
ms.assetid: b3894d34-47b9-4961-9719-4197153793da
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CUrl Class
This class represents a URL. It allows you to manipulate each element of the URL independently of the others whether parsing an existing URL string or building a string from scratch.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CUrl::CUrl](../vs140/curl--curl.md)|The constructor.|  
|[CUrl::~CUrl](../vs140/curl--~curl.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CUrl::Canonicalize](../vs140/curl--canonicalize.md)|Call this method to convert the URL string to canonical form.|  
|[CUrl::Clear](../vs140/curl--clear.md)|Call this method to clear all of the URL fields.|  
|[CUrl::CrackUrl](../vs140/curl--crackurl.md)|Call this method to decode and parse the URL.|  
|[CUrl::CreateUrl](../vs140/curl--createurl.md)|Call this method to create the URL.|  
|[CUrl::GetExtraInfo](../vs140/curl--getextrainfo.md)|Call this method to get extra information (such as ? *text* or # *text*) from the URL.|  
|[CUrl::GetExtraInfoLength](../vs140/curl--getextrainfolength.md)|Call this method to get the length of the extra information (such as ? *text* or # *text*) to retrieve from the URL.|  
|[CUrl::GetHostName](../vs140/curl--gethostname.md)|Call this method to get the host name from the URL.|  
|[CUrl::GetHostNameLength](../vs140/curl--gethostnamelength.md)|Call this method to get the length of the host name.|  
|[CUrl::GetPassword](../vs140/curl--getpassword.md)|Call this method to get the password from the URL.|  
|[CUrl::GetPasswordLength](../vs140/curl--getpasswordlength.md)|Call this method to get the length of the password.|  
|[CUrl::GetPortNumber](../vs140/curl--getportnumber.md)|Call this method to get the port number in terms of ATL_URL_PORT.|  
|[CUrl::GetScheme](../vs140/curl--getscheme.md)|Call this method to get the URL scheme.|  
|[CUrl::GetSchemeName](../vs140/curl--getschemename.md)|Call this method to get the URL scheme name.|  
|[CUrl::GetSchemeNameLength](../vs140/curl--getschemenamelength.md)|Call this method to get the length of the URL scheme name.|  
|[CUrl::GetUrlLength](../vs140/curl--geturllength.md)|Call this method to get the URL length.|  
|[CUrl::GetUrlPath](../vs140/curl--geturlpath.md)|Call this method to get the URL path.|  
|[CUrl::GetUrlPathLength](../vs140/curl--geturlpathlength.md)|Call this method to get the URL path length.|  
|[CUrl::GetUserName](../vs140/curl--getusername.md)|Call this method to get the user name from the URL.|  
|[CUrl::GetUserNameLength](../vs140/curl--getusernamelength.md)|Call this method to get the length of the user name.|  
|[CUrl::SetExtraInfo](../vs140/curl--setextrainfo.md)|Call this method to set the extra information (such as ? *text* or # *text*) of the URL.|  
|[CUrl::SetHostName](../vs140/curl--sethostname.md)|Call this method to set the host name.|  
|[CUrl::SetPassword](../vs140/curl--setpassword.md)|Call this method to set the password.|  
|[CUrl::SetPortNumber](../vs140/curl--setportnumber.md)|Call this method to set the port number in terms of ATL_URL_PORT.|  
|[CUrl::SetScheme](../vs140/curl--setscheme.md)|Call this method to set the URL scheme.|  
|[CUrl::SetSchemeName](../vs140/curl--setschemename.md)|Call this method to set the URL scheme name.|  
|[CUrl::SetUrlPath](../vs140/curl--seturlpath.md)|Call this method to set the URL path.|  
|[CUrl::SetUserName](../vs140/curl--setusername.md)|Call this method to set the user name.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CUrl::operator=](../vs140/curl--operator-=.md)|Assigns the specified <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object to the current <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> allows you to manipulate the fields of a URL, such as the path or port number. <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> understands URLs of the following form:  
  
 \<Scheme>://\<UserName>:\<Password>@\<HostName>:\<PortNumber>/\<UrlPath>\<ExtraInfo>  
  
 (Some fields are optional.) For example, consider this URL:  
  
 http://someone:secret@www.microsoft.com:80/visualc/stuff.htm#contents  
  
 [CUrl::CrackUrl](../vs140/curl--crackurl.md) parses it as follows:  
  
-   Scheme: "http" or [ATL_URL_SCHEME_HTTP](../vs140/atl_url_scheme.md)  
  
-   UserName: "someone"  
  
-   Password: "secret"  
  
-   HostName: "www.microsoft.com"  
  
-   PortNumber: 80  
  
-   UrlPath: "visualc/stuff.htm"  
  
-   ExtraInfo: "#contents"  
  
 To manipulate the UrlPath field (for instance), you would use [GetUrlPath](../vs140/curl--geturlpath.md), [GetUrlPathLength](../vs140/curl--geturlpathlength.md), and [SetUrlPath](../vs140/curl--seturlpath.md). You would use [CreateUrl](../vs140/curl--createurl.md) to create the complete URL string.  
  
## Requirements  
 **Header:** atlutil.h  
  
##  \<a name="curl__canonicalize">\</a>  CUrl::Canonicalize  
 Call this method to convert the URL string to canonical form.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The flags that control canonicalization. If no flags are specified ( <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> = 0), the method converts all unsafe characters and meta sequences (such as \\.,\ .., and \\...) to escape sequences. <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> can be one of the following values:  
  
-   ATL_URL_BROWSER_MODE: Does not encode or decode characters after "#" or "?" and does not remove trailing white space after "?". If this value is not specified, the entire URL is encoded and trailing white space is removed.  
  
-   ATL_URL _DECODE: Converts all %XX sequences to characters, including escape sequences, before the URL is parsed.  
  
-   ATL_URL _ENCODE_PERCENT: Encodes any percent signs encountered. By default, percent signs are not encoded.  
  
-   ATL_URL _ENCODE_SPACES_ONLY: Encodes spaces only.  
  
-   ATL_URL _NO_ENCODE: Does not convert unsafe characters to escape sequences.  
  
-   ATL_URL _NO_META: Does not remove meta sequences (such as "." and "..") from the URL.  
  
### Return Value  
 Returns TRUE on success, FALSE on failure.  
  
### Remarks  
 Converting to canonical form involves converting unsafe characters and spaces to escape sequences.  
  
##  \<a name="curl__clear">\</a>  CUrl::Clear  
 Call this method to clear all of the URL fields.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="curl__crackurl">\</a>  CUrl::CrackUrl  
 Call this method to decode and parse the URL.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 The URL.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 Specify ATL_URL_DECODE or ATL_URL_ESCAPE to convert all escape characters in <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> to their real values after parsing. (Before Visual C++ 2005, ATL_URL_DECODE converted all escape characters before parsing.)  
  
### Return Value  
 Returns TRUE on success, FALSE on failure.  
  
##  \<a name="curl__createurl">\</a>  CUrl::CreateUrl  
 This method constructs a URL string from a CUrl object's component fields.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 *lpszUrl*  
 A string buffer to hold the complete URL string.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 The maximum length of the *lpszUrl* string buffer.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 Specify ATL_URL_ESCAPE to convert all escape characters in *lpszUrl* to their real values.  
  
### Return Value  
 Returns TRUE on success, FALSE on failure.  
  
### Remarks  
 This method appends its individual fields in order to construct the complete URL string using the following format:  
  
 **\<scheme>://\<user>:\<pass>@\<domain>:\<port>\<path>\<extra>**  
  
 When calling this method, the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> parameter should initially contain the maximum length of the string buffer referenced by the *lpszUrl* parameter. The value of the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> parameter will be updated with the actual length of the URL string.  
  
### Example  
 This sample demonstrates creation of a CUrl object and retrieving its URL string  
  
 [!code[NVC_ATL_Utilities#133](../vs140/codesnippet/CPP/curl-class_1.cpp)]  
  
##  \<a name="curl__curl">\</a>  CUrl::CUrl  
 The constructor.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object to copy to create the URL.  
  
##  \<a name="curl___dtorcurl">\</a>  CUrl::~CUrl  
 The destructor.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="curl__getextrainfo">\</a>  CUrl::GetExtraInfo  
 Call this method to get extra information (such as ? *text* or # *text*) from the URL.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 Returns a string containing the extra information.  
  
##  \<a name="curl__getextrainfolength">\</a>  CUrl::GetExtraInfoLength  
 Call this method to get the length of the extra information (such as ? *text* or # *text*) to retrieve from the URL.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 Returns the length of the string containing the extra information.  
  
##  \<a name="curl__gethostname">\</a>  CUrl::GetHostName  
 Call this method to get the host name from the URL.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 Returns the host name.  
  
##  \<a name="curl__gethostnamelength">\</a>  CUrl::GetHostNameLength  
 Call this method to get the length of the host name.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 Returns the host name length.  
  
##  \<a name="curl__getpassword">\</a>  CUrl::GetPassword  
 Call this method to get the password from the URL.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 Returns the password.  
  
##  \<a name="curl__getpasswordlength">\</a>  CUrl::GetPasswordLength  
 Call this method to get the length of the password.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 Returns the password length.  
  
##  \<a name="curl__getportnumber">\</a>  CUrl::GetPortNumber  
 Call this method to get the port number.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 Returns the port number.  
  
##  \<a name="curl__getscheme">\</a>  CUrl::GetScheme  
 Call this method to get the URL scheme.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 Returns the [ATL_URL_SCHEME](../vs140/atl_url_scheme.md) value describing the scheme of the URL.  
  
##  \<a name="curl__getschemename">\</a>  CUrl::GetSchemeName  
 Call this method to get the URL scheme name.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 Returns the URL scheme name (such as "http" or "ftp").  
  
##  \<a name="curl__getschemenamelength">\</a>  CUrl::GetSchemeNameLength  
 Call this method to get the length of the URL scheme name.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 Returns the URL scheme name length.  
  
##  \<a name="curl__geturllength">\</a>  CUrl::GetUrlLength  
 Call this method to get the URL length.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 Returns the URL length.  
  
##  \<a name="curl__geturlpath">\</a>  CUrl::GetUrlPath  
 Call this method to get the URL path.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
 Returns the URL path.  
  
##  \<a name="curl__geturlpathlength">\</a>  CUrl::GetUrlPathLength  
 Call this method to get the URL path length.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 Returns the URL path length.  
  
##  \<a name="curl__getusername">\</a>  CUrl::GetUserName  
 Call this method to get the user name from the URL.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
 Returns the user name.  
  
##  \<a name="curl__getusernamelength">\</a>  CUrl::GetUserNameLength  
 Call this method to get the length of the user name.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 Returns the user name length.  
  
##  \<a name="curl__operator__eq">\</a>  CUrl::operator =  
 Assigns the specified <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object to the current <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> object to copy into the current object.  
  
### Return Value  
 Returns a reference to the current object.  
  
##  \<a name="curl__setextrainfo">\</a>  CUrl::SetExtraInfo  
 Call this method to set the extra information (such as ? *text* or # *text*) of the URL.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 *lpszInfo*  
 The string containing the extra information to include in the URL.  
  
### Return Value  
 Returns TRUE on success, FALSE on failure.  
  
##  \<a name="curl__sethostname">\</a>  CUrl::SetHostName  
 Call this method to set the host name.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 The host name.  
  
### Return Value  
 Returns TRUE on success, FALSE on failure.  
  
##  \<a name="curl__setpassword">\</a>  CUrl::SetPassword  
 Call this method to set the password.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 *lpszPass*  
 The password.  
  
### Return Value  
 Returns TRUE on success, FALSE on failure.  
  
##  \<a name="curl__setportnumber">\</a>  CUrl::SetPortNumber  
 Call this method to set the port number.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 *nPrt*  
 The port number.  
  
### Return Value  
 Returns TRUE on success, FALSE on failure.  
  
##  \<a name="curl__setscheme">\</a>  CUrl::SetScheme  
 Call this method to set the URL scheme.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 One of the [ATL_URL_SCHEME](../vs140/atl_url_scheme.md) values for the scheme.  
  
### Return Value  
 Returns TRUE on success, FALSE on failure.  
  
### Remarks  
 You can also set the scheme by name (see [CUrl::SetSchemeName](../vs140/curl--setschemename.md)).  
  
##  \<a name="curl__setschemename">\</a>  CUrl::SetSchemeName  
 Call this method to set the URL scheme name.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 *lpszSchm*  
 The URL scheme name.  
  
### Return Value  
 Returns TRUE on success, FALSE on failure.  
  
### Remarks  
 You can also set the scheme by using an [ATL_URL_SCHEME](../vs140/atl_url_scheme.md) constant (see [CUrl::SetScheme](../vs140/curl--setscheme.md)).  
  
##  \<a name="curl__seturlpath">\</a>  CUrl::SetUrlPath  
 Call this method to set the URL path.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 The URL path.  
  
### Return Value  
 Returns TRUE on success, FALSE on failure.  
  
##  \<a name="curl__setusername">\</a>  CUrl::SetUserName  
 Call this method to set the user name.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 *lpszUser*  
 The user name.  
  
### Return Value  
 Returns TRUE on success, FALSE on failure.  
  
## See Also  
 [ATL Classes](../vs140/atl-classes.md)