import { Rol } from "./rol.model";

export interface User {
  id: string,
  relo: string,
  email: string,
  password: string,
  firstName: string,
  lastName: string,
  address: string,
  phoneNumber: string,
  rol: Rol,
}
