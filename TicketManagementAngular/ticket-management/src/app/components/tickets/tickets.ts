import { Component, signal } from '@angular/core';
import { TicketService } from '../../services/ticket-service';
import { DatePipe, NgClass, NgFor } from '@angular/common';
import { CapitalizeFirstPipe } from '../../pipes/capitalize-first-pipe';

@Component({
  selector: 'app-tickets',
  imports: [NgFor, DatePipe, NgClass, CapitalizeFirstPipe],
  templateUrl: './tickets.html',
  styleUrl: './tickets.css',
})
export class Tickets {
  tickets = signal<any[]>([]);

  constructor(private ticketService : TicketService) {
    this.loadTickets();
  }

  loadTickets() {
    this.ticketService.getTickets().subscribe((data) => {
      this.tickets.set(data);
    });
  }
}
