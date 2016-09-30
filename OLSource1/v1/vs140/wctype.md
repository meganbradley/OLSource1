---
title: "wctype"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "wctype"
apilocation: 
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "wctype"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "wctype function"
  - "wide characters"
ms.assetid: 14aded12-4087-4123-bc48-db4e10999223
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# wctype
Determines a classification rule for wide-character codes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Property string.  
  
## Return Value  
 If the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> category of the current locale does not define a classification rule whose name matches the property string <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, the function returns zero. Otherwise, it returns a nonzero value suitable for use as the second argument to a subsequent call to [towctrans](../vs140/towctrans.md).  
  
## Remarks  
 The function determines a classification rule for wide-character codes. The following pairs of calls have the same behavior in all locales (but an implementation can define additional classification rules even in the "C" locale):  
  
|Function|Same as|  
|--------------|-------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>|\<wctype.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md)