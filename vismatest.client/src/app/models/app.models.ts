export interface IDeveloper {
  firstName: string;
  lastName: string;
  salary: number;
  email: string;
  department: IDepartment;
  manager: IManager;
}

export interface IManager {
  firstName: string;
  lastName: number;
  salary: number;
  email: string;
  department: IDepartment;
}
export interface IDepartment {
  name: string;
  info: string;
}
