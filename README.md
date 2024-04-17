# Приложение "Список рекомендаций фильмов"
:ballot_box_with_check: [Техническое задание](https://github.com/Leeiss/TeamProject2_ListOfRecommendations/commit/98bab1c921484e598075919703483456221fa733)  :ballot_box_with_check: [Презентация](https://github.com/Leeiss/TeamProject2_ListOfRecommendations/commit/afc102dab0082bd071b2aaa9d17a6619ca54fd5b)  :ballot_box_with_check: [Баг-репорт](https://github.com/Leeiss/TeamProject2_ListOfRecommendations/blob/master/%D0%91%D0%B0%D0%B3%20%D0%A0%D0%B5%D0%BF%D0%BE%D1%80%D1%82%2030.04.2023.docx)  
  
Финальная версия проекта [здесь](https://github.com/Leeiss/TeamProject2_ListOfRecommendations)

Участники проекта  
Аналитик: [Azat](https://github.com/Baby1ner)   
Разработчик: [Leisan](https://github.com/Leeiss)     
Тестировщик: [Kirill](https://github.com/kirillarsentev)   

  
_____
### Приложение предназначено для нахождения интересующих человека фильмов   
#### Цели:
 :cd: Подбор фильмов, которые будут интересны человеку, основываясь на его характеристиках, оценках по фильмам.
  
 :cd: Возможность добавлять свои фильмы;  
  
 :cd:  Возможность составлять свои собственные подборки;
    
 :cd:  Поиск фильмов с использованием API.
  
_____
### Содержание
>[Авторизация/Регистрация](#1)   
>[Работа приложения](#2)  
> > [Рекомендации](#5)  
> > [Подборки](#3)  
> > [Поиск фильмов](#4) 
<br>
    
______

 
<a name="1"></a>    
## Авторизация/Регистрация  
<img src="https://github.com/Leeiss/TeamProject2_ListOfRecommendations/blob/develop/TeamProject2__ListOfRecommendations/Resources/%D1%80%D0%B5%D0%B3%D0%B8%D1%81%D1%82%D1%80%D0%B0%D1%86%D0%B8%D1%8F%20%D0%B8%20%D0%B0%D0%B2%D1%82%D0%BE%D1%80%D0%B8%D0%B7%D0%B0%D1%86%D0%B8%D1%8F.png" alt="Основное окно" width="800"/>

 Для того чтобы зарегестрироваться, пользователю нужно подтвердить адрес электронной почты. Также пользователь может подтвердить права админа, если такие имеются. У админа есть возможность добавлять фильмы и актеров в базу данных фильмов приложения  
<img src="https://github.com/Leeiss/TeamProject2_ListOfRecommendations/blob/develop/TeamProject2__ListOfRecommendations/Resources/%D0%BF%D1%80%D0%BE%D1%86%D0%B5%D1%81%D1%81%D1%8B%20%D1%80%D0%B5%D0%B3%D0%B8%D1%81%D1%82%D1%80%D0%B0%D1%86%D0%B8%D0%B8.png" alt="Основное окно" width="800"/>  
<br>     
 
###### Письма, которые отправляются пользователю
> <img src="https://github.com/Leeiss/TeamProject2_ListOfRecommendations/blob/develop/TeamProject2__ListOfRecommendations/Resources/%D0%BF%D0%B8%D1%81%D1%8C%D0%BC%D0%B0%20%D0%BD%D0%B0%20%D0%BF%D0%BE%D1%87%D1%82%D1%83.png" alt="Основное окно" width="1100"/>  
<br>   
   
Подтвердив адрес электронной почты, пользователь дает приложению данные о своих предпочтениях: любимых актеров и любимых жанрах.   
 Фильмы, жанры и актеры которого явлются любимыми пользователя, будут чаще выходить в рекомендации пользователя.
<img src="https://github.com/Leeiss/TeamProject2_ListOfRecommendations/blob/develop/TeamProject2__ListOfRecommendations/Resources/%D0%BF%D1%80%D0%B5%D0%B4%D0%BF%D0%BE%D1%87%D1%82%D0%B5%D0%BD%D0%B8%D1%8F%20%D0%BF%D0%BE%D0%BB%D1%8C%D0%B7%D0%BE%D0%B2%D0%B0%D1%82%D0%B5%D0%BB%D1%8F.png" alt="Основное окно" width="1100"/>  
  
<br>   
    
__________
     
<a name="2"></a>   
## Работа приложения  
  <br> 
<a name="5"></a>  

### Рекомендации    
+ Пользователь, войдя в приложение, видит фильмы, которые с большей вероятностью могут ему понравиться.    
Оценивания фильм, пользователь дает понять, насколько сильно он хочет, чтобы данный фильм вновь попал ему в рекомендацию. Также пользователь может сделать пропуск, чтобы увидеть следущий фильм.
<img src="https://github.com/Leeiss/TeamProject2_ListOfRecommendations/blob/develop/TeamProject2__ListOfRecommendations/Resources/%D0%BF%D1%80%D0%BE%D0%BF%D1%83%D1%81%D0%BA%20%D1%84%D0%B8%D0%BB%D1%8C%D0%BC%D0%BE%D0%B2.png" alt="Основное окно" width="1100"/>  
     
+ Также пользователь может выбрать конкретные характеристики, которым должны соответствовать рекомендуемые фильмы.   
   
<img src="https://github.com/Leeiss/TeamProject2_ListOfRecommendations/blob/develop/TeamProject2__ListOfRecommendations/Resources/%D1%85%D0%B0%D1%80%D0%B0%D0%BA%D1%82%D0%B5%D1%80%D0%B8%D1%81%D1%82%D0%B8%D0%BA%D0%B8.png" alt="Основное окно" width="1100"/>     
  
+ Кликнув на название фильма, можно посмотреть подробную информацию о фильме.   
   
<img src="https://github.com/Leeiss/TeamProject2_ListOfRecommendations/blob/develop/TeamProject2__ListOfRecommendations/Resources/%D0%B8%D0%BD%D1%84%D0%BE%D1%80%D0%BC%D0%B0%D1%86%D0%B8%D1%8F%20%D0%BE%20%D1%84%D0%B8%D0%BB%D1%8C%D0%BC%D0%B5.png" alt="Основное окно" width="900"/>   
  
+ Кликнув на постер фильма, можно перейти по ссылке, где можно посмотреть фильм.
   
<img src="https://github.com/Leeiss/TeamProject2_ListOfRecommendations/blob/develop/TeamProject2__ListOfRecommendations/Resources/%D0%BF%D1%80%D0%BE%D1%81%D0%BC%D0%BE%D1%82%D1%80%20%D1%84%D0%B8%D0%BB%D1%8C%D0%BC%D0%B0%20%D0%BF%D0%BE%20%D1%81%D1%81%D1%8B%D0%BB%D0%BA%D0%B5.png" alt="Основное окно" width="1100"/>   
 
    
<a name="3"></a>
### Подборки
+ Также пользователь может создавать подборки. После регистрации у пользователя только одна подборка - "Избранное".
   
<img src="https://github.com/Leeiss/TeamProject2_ListOfRecommendations/blob/develop/TeamProject2__ListOfRecommendations/Resources/%D1%81%D0%BE%D0%B7%D0%B4%D0%B0%D0%BD%D0%B8%D0%B5%20%D0%BF%D0%BE%D0%B4%D0%B1%D0%BE%D1%80%D0%BA%D0%B8.png" alt="Основное окно" width="800"/>    

 + Кликнув на плюс, пользователь может добавить фильм в свою подборку.  
   
<img src="https://github.com/Leeiss/TeamProject2_ListOfRecommendations/blob/develop/TeamProject2__ListOfRecommendations/Resources/%D0%B4%D0%BE%D0%B1%D0%B0%D0%B2%D0%BB%D0%B5%D0%BD%D0%B8%D0%B5%20%D0%B2%20%D0%BF%D0%BE%D0%B4%D0%B1%D0%BE%D1%80%D0%BA%D1%83.png" alt="Основное окно" width="800"/>   

+ Кликнув на звезду, пользователь может добавить фильм в избранное.
   
<img src="https://github.com/Leeiss/TeamProject2_ListOfRecommendations/blob/develop/TeamProject2__ListOfRecommendations/Resources/%D0%B8%D0%B7%D0%B1%D1%80%D0%B0%D0%BD%D0%BD%D0%BE%D0%B5.png" alt="Основное окно" width="1100"/>   

+ Выбрав подборку, пользователь может перейти к просмотру фильма, которые в ней находятся.
   
<img src="https://github.com/Leeiss/TeamProject2_ListOfRecommendations/blob/develop/TeamProject2__ListOfRecommendations/Resources/%D0%BF%D1%80%D0%BE%D1%81%D0%BC%D0%BE%D1%82%D1%80%20%D1%84%D0%B8%D0%BB%D1%8C%D0%BC%D0%B0%20%D0%B8%D0%B7%20%D0%BA%D0%BE%D0%BB%D0%BB%D0%B5%D0%BA%D1%86%D0%B8%D0%B8.png" alt="Основное окно" width="1100"/>    

+ Также пользователь может удалять свои подборки, добавлять и удалять фильмы.
   
<img src="https://github.com/Leeiss/TeamProject2_ListOfRecommendations/blob/develop/TeamProject2__ListOfRecommendations/Resources/%D0%B8%D0%B7%D0%BC%D0%B5%D0%BD%D0%B5%D0%BD%D0%B8%D0%B5%20%D0%BF%D0%BE%D0%B4%D0%B1%D0%BE%D1%80%D0%BE%D0%BA.png" alt="Основное окно" width="600"/>    

+ Помимо этого, у приложения есть готовые коллекции, которые может просматривать пользователь.
   
<img src="https://github.com/Leeiss/TeamProject2_ListOfRecommendations/blob/develop/TeamProject2__ListOfRecommendations/Resources/%D0%BA%D0%BE%D0%BB%D0%BB%D0%B5%D0%BA%D1%86%D0%B8%D0%B8%20%D0%BF%D1%80%D0%B8%D0%BB%D0%BE%D0%B6%D0%B5%D0%BD%D0%B8%D1%8F.png" alt="Основное окно" width="1100"/>   
<br>    
 <br> 
    
<a name="4"></a>
### Поиск фильмов в приложении представлен 2 способами   
+ Поиск фильмов из базы данных приложения  

<img src="https://github.com/Leeiss/TeamProject2_ListOfRecommendations/blob/develop/TeamProject2__ListOfRecommendations/Resources/%D0%BF%D0%BE%D0%B8%D1%81%D0%BA%20%D1%84%D0%B8%D0%BB%D1%8C%D0%BC%D0%BE%D0%B2%20%D0%BF%D1%80%D0%B8%D0%BB%D0%BE%D0%B6%D0%B5%D0%BD%D0%B8%D1%8F.png" alt="Основное окно" width="1100"/>     
<br> 
   
+ Поиск фильмов с использованием данных веб-службы OMDb API
 
<img src="https://github.com/Leeiss/TeamProject2_ListOfRecommendations/blob/develop/TeamProject2__ListOfRecommendations/Resources/%D0%BF%D0%BE%D0%B8%D1%81%D0%BA%20%D0%BF%D0%BE%20api.png" alt="Основное окно" width="1100"/>  
       












