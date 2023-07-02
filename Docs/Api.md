# SpeedEat API

- [SpeedEat API](#speedeat-api)
    - [Auth](#auth)
        - [Register](#register)
            - [Register Request](#register-request)
            - [Register Response](#register-response)
        - [Login](#login)
            - [Login Request](#login-request)
            - [Login Response](#login-response)

<hr>

## Auth

<hr>

### Register

```js
POST {{host}}/auth/register
```

#### Register Request

```json
{
    "firstName": "Leonardo",
    "lastName": "Majevski",
    "email": "majevski@live.com",
    "password": "pass1234"
}
```

#### Register Response
```json
200 OK
```

```json
{
    "id": "d89c2d9a-eb3e-4075-95ff-b920b55aa104",
    "firstName": "Leonardo",
    "lastName": "Majevski",
    "email": "majevski@live.com",
    "token": "eyJhb..z9dqcnXoY"
}
```

<hr>

### Login

```js
POST {{host}}/auth/login
```

#### Login Request

```json
{
    "firstName": "Leonardo",
    "lastName": "Majevski",
    "email": "majevski@live.com",
    "password": "pass1234"
}
```

#### Login Response
```json
200 OK
```

```json
{
    "id": "d89c2d9a-eb3e-4075-95ff-b920b55aa104",
    "firstName": "Leonardo",
    "lastName": "Majevski",
    "email": "majevski@live.com",
    "token": "eyJhb..z9dqcnXoY"
}