# Приложение "Список рекомендаций фильмов"
:ballot_box_with_check: [Техническое задание]()  :ballot_box_with_check: [Презентация]()  :ballot_box_with_check: [Баг-репорт]()  
  
Финальная версия проекта [здесь]()
____
Участники проекта  
Аналитик: [Azat](https://github.com/Baby1ner)   
Разработчик: [Leisan](https://github.com/Leeiss)     
Тестировщик: [Kirill](https://github.com/kirillarsentev)   

  
_____
### Приложение предназначено для нахождения интересующих человека фильмов   
#### Цели:
 :white_check_mark: Подбор фильмов, которые будут интересны человеку, основываясь на его характеристиках, оценках по фильмам.
  
 :white_check_mark: Возможность добавлять свои фильмы;  
  
 :white_check_mark:  Возможность составлять свои собственные подборки;
    
 :white_check_mark:  Поиск фильмов с использованием API.
  
_____
### Структура. Экраны
Авторизация и регистрация  
Подбор (главный экран)  
Изменение характеристик   
Добавление своего фильма  
Просмотр подборки  
Создание новой подборки  
Добавление рекомендуемого фильма в подборку  
Изменение подборок  

  
______

 
    
## Авторизация/Регистрация  
<img src="https://github.com/Leeiss/TeamProject2_ListOfRecommendations/blob/develop/TeamProject2__ListOfRecommendations/Resources/%D1%80%D0%B5%D0%B3%D0%B8%D1%81%D1%82%D1%80%D0%B0%D1%86%D0%B8%D1%8F%20%D0%B8%20%D0%B0%D0%B2%D1%82%D0%BE%D1%80%D0%B8%D0%B7%D0%B0%D1%86%D0%B8%D1%8F.png" alt="Основное окно" width="800"/>
<br> 
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
     
## Работа приложения  
  <br> 
     
### Рекомендации
Пользователь, войдя в приложение, видит фильмы, которые с большей вероятностью могут ему понравиться.    
Оценивания фильм, пользователь дает понять, насколько сильно он хочет, чтобы данный фильм вновь попал ему в рекомендацию. Также пользователь может сделать пропуск, чтобы увидеть следущий фильм.
<img src="https://github.com/Leeiss/TeamProject2_ListOfRecommendations/blob/develop/TeamProject2__ListOfRecommendations/Resources/%D0%BF%D1%80%D0%BE%D0%BF%D1%83%D1%81%D0%BA%20%D1%84%D0%B8%D0%BB%D1%8C%D0%BC%D0%BE%D0%B2.png" alt="Основное окно" width="1100"/>  
     <br> 
Также пользователь может выбрать конкретные характеристики, которым должны соответствовать рекомендуемые фильмы.   
   
<img src="https://github.com/Leeiss/TeamProject2_ListOfRecommendations/blob/develop/TeamProject2__ListOfRecommendations/Resources/%D1%85%D0%B0%D1%80%D0%B0%D0%BA%D1%82%D0%B5%D1%80%D0%B8%D1%81%D1%82%D0%B8%D0%BA%D0%B8.png" alt="Основное окно" width="1100"/>     
  <br> 
Кликнув на название фильма, можно посмотреть подробную информацию о фильме.   
   
<img src="https://github.com/Leeiss/TeamProject2_ListOfRecommendations/blob/develop/TeamProject2__ListOfRecommendations/Resources/%D0%B8%D0%BD%D1%84%D0%BE%D1%80%D0%BC%D0%B0%D1%86%D0%B8%D1%8F%20%D0%BE%20%D1%84%D0%B8%D0%BB%D1%8C%D0%BC%D0%B5.png" alt="Основное окно" width="900"/>   
  <br> 
Кликнув на постер фильма, можно перейти по ссылке, где можно посмотреть фильм.
   
<img src="https://github.com/Leeiss/TeamProject2_ListOfRecommendations/blob/develop/TeamProject2__ListOfRecommendations/Resources/%D0%BF%D1%80%D0%BE%D1%81%D0%BC%D0%BE%D1%82%D1%80%20%D1%84%D0%B8%D0%BB%D1%8C%D0%BC%D0%B0%20%D0%BF%D0%BE%20%D1%81%D1%81%D1%8B%D0%BB%D0%BA%D0%B5.png" alt="Основное окно" width="1100"/>   
 <br> 
    
### Подборки
Также пользователь может создавать подборки. После регистрации у пользователя только одна подборка - "Избранное".
   
<img src="https://github.com/Leeiss/TeamProject2_ListOfRecommendations/blob/develop/TeamProject2__ListOfRecommendations/Resources/%D1%81%D0%BE%D0%B7%D0%B4%D0%B0%D0%BD%D0%B8%D0%B5%20%D0%BF%D0%BE%D0%B4%D0%B1%D0%BE%D1%80%D0%BA%D0%B8.png" alt="Основное окно" width="800"/>    
 <br> 
Кликнув на плюс, пользователь может добавить фильм в свою подборку.  
   
<img src="https://github.com/Leeiss/TeamProject2_ListOfRecommendations/blob/develop/TeamProject2__ListOfRecommendations/Resources/%D0%B4%D0%BE%D0%B1%D0%B0%D0%B2%D0%BB%D0%B5%D0%BD%D0%B8%D0%B5%20%D0%B2%20%D0%BF%D0%BE%D0%B4%D0%B1%D0%BE%D1%80%D0%BA%D1%83.png" alt="Основное окно" width="800"/>   
<br> 
Кликнув на звезду, пользователь может добавить фильм в избранное.
   
<img src="https://github.com/Leeiss/TeamProject2_ListOfRecommendations/blob/develop/TeamProject2__ListOfRecommendations/Resources/%D0%B8%D0%B7%D0%B1%D1%80%D0%B0%D0%BD%D0%BD%D0%BE%D0%B5.png" alt="Основное окно" width="1100"/>   
<br> 
Выбрав подборку, пользователь может перейти к просмотру фильма, которые в ней находятся.
   
<img src="https://github.com/Leeiss/TeamProject2_ListOfRecommendations/blob/develop/TeamProject2__ListOfRecommendations/Resources/%D0%BF%D1%80%D0%BE%D1%81%D0%BC%D0%BE%D1%82%D1%80%20%D1%84%D0%B8%D0%BB%D1%8C%D0%BC%D0%B0%20%D0%B8%D0%B7%20%D0%BA%D0%BE%D0%BB%D0%BB%D0%B5%D0%BA%D1%86%D0%B8%D0%B8.png" alt="Основное окно" width="1100"/>    
<br> 
Также пользователь может удалять свои подборки, добавлять и удалять фильмы.
   
<img src="https://github.com/Leeiss/TeamProject2_ListOfRecommendations/blob/develop/TeamProject2__ListOfRecommendations/Resources/%D0%B8%D0%B7%D0%BC%D0%B5%D0%BD%D0%B5%D0%BD%D0%B8%D0%B5%20%D0%BF%D0%BE%D0%B4%D0%B1%D0%BE%D1%80%D0%BE%D0%BA.png" alt="Основное окно" width="600"/>    
<br> 
Помимо этого, у приложения есть готовые коллекции, которые может просматривать пользователь.
   
<img src="https://github.com/Leeiss/TeamProject2_ListOfRecommendations/blob/develop/TeamProject2__ListOfRecommendations/Resources/%D0%BA%D0%BE%D0%BB%D0%BB%D0%B5%D0%BA%D1%86%D0%B8%D0%B8%20%D0%BF%D1%80%D0%B8%D0%BB%D0%BE%D0%B6%D0%B5%D0%BD%D0%B8%D1%8F.png" alt="Основное окно" width="1100"/>   
<br>    
 <br> 
        
### Поиск фильмов в приложении представлен 2 способами   
+ Поиск фильмов из базы данных приложения  

<img src="https://github.com/Leeiss/TeamProject2_ListOfRecommendations/blob/develop/TeamProject2__ListOfRecommendations/Resources/%D0%BF%D0%BE%D0%B8%D1%81%D0%BA%20%D1%84%D0%B8%D0%BB%D1%8C%D0%BC%D0%BE%D0%B2%20%D0%BF%D1%80%D0%B8%D0%BB%D0%BE%D0%B6%D0%B5%D0%BD%D0%B8%D1%8F.png" alt="Основное окно" width="1100"/>     
<br> 
   
+ Поиск фильмов с использованием данных веб-службы OMDb API
 
<img src="https://github.com/Leeiss/TeamProject2_ListOfRecommendations/blob/develop/TeamProject2__ListOfRecommendations/Resources/%D0%BF%D0%BE%D0%B8%D1%81%D0%BA%20%D0%BF%D0%BE%20api.png" alt="Основное окно" width="1100"/>  












