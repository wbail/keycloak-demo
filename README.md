# Demo Keycloak Authentication + Reverse Proxy (Yarp)

- Containerized application
- Using Keycloak to perform the authentication and authorization
- Added the reverse proxy (yarp) to redirect the requests to the authentication api
- Returns the ```claims``` from the authenticated user
- Jaeger to visualize the requests

### Usage

- Create the realm into keycloak admin control panel
- Use the client to perform the authentication via swagger to get the bearer token
- Perform a get request against revese proxy to get the claims
- Open Jaeger interface to visualize the requests
