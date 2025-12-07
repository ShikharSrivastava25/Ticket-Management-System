import { Routes } from '@angular/router';
import { Tickets } from './components/tickets/tickets';

export const routes: Routes = [
  {path: 'components/tickets', component: Tickets},
  { path: '', redirectTo: '/components/tickets', pathMatch: 'full' }
];
