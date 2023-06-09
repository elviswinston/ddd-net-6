# Sample API

- [Sample API](#sample-api)
  - [Auth](#auth)
    - [Register](#register)
      - [Register Request](#register-request)
      - [Register Response](#register-response)
    - [Login](#login)
      - [Login Request](#login-request)
      - [Login Response](#login-response)

## Auth

### Register

```js
POST {{host}}/auth/register
```


#### Register Request

```json
{
    "firstName": "Test",
    "LastName": "Test",
    "email": "test@gmail.com",
    "password": "test"
}
```

#### Register Response

```js
200 OK
```

```json
{
    "id": "d89c29a-eb3e-4075-95ff-b920b55aa104",
    "firstName": "Test",
    "lastName": "Test",
    "email": "test@gmail.com",
    "token": "eyJhb..z9dqcnXoY"
}
```

### Login

```js
POST {{host}}/auth/login
```

#### Login Request

```json
{
    "email": "test@gmail.com",
    "password": "test"
}
```

#### Login Response

```js
200 OK
```

```json
{
    "id": "d89c29a-eb3e-4075-95ff-b920b55aa104",
    "firstName": "Test",
    "lastName": "Test",
    "email": "test@gmail.com",
    "token": "eyJhb..z9dqcnXoY"
}
```