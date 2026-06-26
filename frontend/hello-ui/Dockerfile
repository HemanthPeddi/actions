# ---------- Build Stage ----------
FROM node:20 AS build

WORKDIR /app

COPY package*.json ./

RUN npm ci

COPY . .

RUN npm run build

# ---------- Runtime Stage ----------
FROM nginx:alpine

COPY --from=build /app/dist/hello-ui/browser /usr/share/nginx/html

EXPOSE 80