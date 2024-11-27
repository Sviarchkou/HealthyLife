CREATE TYPE SEX AS ENUM ('male','female', 'other');
CREATE TYPE GOAL AS ENUM ('loss','maintenance', 'gain');
CREATE TYPE ACTIVITY AS ENUM ('low','medium', 'high');

CREATE TABLE users
(
    id            uuid PRIMARY KEY  DEFAULT gen_random_uuid() NOT NULL,
    username      varchar  NOT NULL UNIQUE,
    password      varchar  NOT NULL,
    role          boolean  NOT NULL DEFAULT false,
    sex           SEX      NOT NULL,
    weight        real     NOT NULL,
    height        integer  NOT NULL,
    activity      ACTIVITY NOT NULL,
    goal          GOAL     NOT NULL,
    date_of_birth date,
    photo         text
);

CREATE TABLE user_weight
(
    id         serial PRIMARY KEY         NOT NULL UNIQUE,
    user_id    uuid REFERENCES users (id) NOT NULL,
    updated_at date                       NOT NULL UNIQUE,
    weight     real                       NOT NULL,
    goal       real
);

CREATE TABLE elements
(
    id            serial PRIMARY KEY NOT NULL UNIQUE,
    calories      integer            NOT NULL,
    proteins      real               NOT NULL,
    fats          real               NOT NULL,
    carbohydrates real               NOT NULL,
    minerals      varchar,
    vitamins      varchar
);

CREATE TABLE products
(
    id          serial PRIMARY KEY              NOT NULL UNIQUE,
    name        TEXT                            NOT NULL,
    category    TEXT                            NOT NULL,
    description TEXT,
    element_id  serial REFERENCES elements (id) NOT NULL UNIQUE,
    photo       text
);

CREATE TABLE recipes
(
    id          serial PRIMARY KEY              NOT NULL UNIQUE,
    name        TEXT                            NOT NULL,
    description TEXT,
    element_id  serial REFERENCES elements (id) NOT NULL UNIQUE,
    photo       text
);

CREATE TABLE ingredients
(
    id         serial                          NOT NULL UNIQUE,
    weight     INTEGER                         NOT NULL,
    product_id serial REFERENCES products (id) NOT NULL,
    recipe_id  serial REFERENCES recipes (id)  NOT NULL
);

CREATE TABLE user_has_recipes
(
    user_id   uuid REFERENCES users (id)     NOT NULL,
    recipe_id serial REFERENCES recipes (id) NOT NULL
);

CREATE TABLE diets
(
    id          serial PRIMARY KEY         NOT NULL UNIQUE,
    name        TEXT                       NOT NULL,
    description TEXT,
    user_id     uuid REFERENCES users (id) NOT NULL UNIQUE,
    photo       text
);

CREATE TABLE meals
(
    id           serial PRIMARY KEY              NOT NULL UNIQUE,
    breakfast_id serial REFERENCES recipes (id),
    lunch_id     serial REFERENCES recipes (id),
    dinner_id    serial REFERENCES recipes (id),
    element_id   serial REFERENCES elements (id) NOT NULL
);

CREATE TABLE extra_food
(
    product_id serial REFERENCES products (id) NOT NULL,
    meal_id    serial REFERENCES meals (id)    NOT NULL
);

CREATE TABLE diet_has_meals
(
    meal_id serial REFERENCES meals (id) NOT NULL,
    diet_id serial REFERENCES diets (id) NOT NULL
);

CREATE TABLE user_has_diet
(
    user_id uuid REFERENCES users (id)   NOT NULL,
    diet_id serial REFERENCES diets (id) NOT NULL
);

CREATE TABLE user_require_elements
(
    user_id    uuid REFERENCES users (id)      NOT NULL UNIQUE,
    element_id serial REFERENCES elements (id) NOT NULL UNIQUE
);

CREATE TABLE user_daily_elements
(
    id         serial PRIMARY KEY              NOT NULL UNIQUE,
    user_id    uuid REFERENCES users (id)      NOT NULL,
    element_id serial REFERENCES elements (id) NOT NULL UNIQUE,
    updated_at date                            NOT NULL
);

CREATE TABLE user_daily_meal
(
    id         serial PRIMARY KEY           NOT NULL UNIQUE,
    user_id    uuid REFERENCES users (id)   NOT NULL,
    meal_id    serial REFERENCES meals (id) NOT NULL,
    updated_at date                         NOT NULL
);
